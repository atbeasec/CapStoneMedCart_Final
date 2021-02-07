Imports System.Text

Public Class frmUpdatePatient
    '/*********************************************************************/
    '/*                   SUBPRORGRAM NAME:frmUpdatePatient_Load		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 2/5/2021                 		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:		            						   */             
    '/*	 This is going to run when the 	frmUpdatePatient is called. It will */
    '/*  find the patient being updated via the tag that is on the sender.*/
    '/*  The tag on the sender is going to be the MRN number of the patient.*/
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*  sender – Identifies which particular control raised the          */
    '/*          click event                                              */
    '/*  e – Holds the EventArgs object sent to the routine               */        
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Private dsPatient As DataSet = New DataSet
    Private dsRooms As DataSet = New DataSet
    Private dsPatientRoom As DataSet = New DataSet


    Private Sub frmUpdatePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sender.tag = 278769641

        Dim strbSQLString = New StringBuilder()
        strbSQLString.Append("Select * from Patient where MRN_Number = '" & sender.tag & "';")
        dsPatient = CreateDatabase.ExecuteSelectQuery(strbSQLString.ToString)

        strbSQLString.Clear()
        strbSQLString.Append("Select * from Rooms;")
        dsRooms = CreateDatabase.ExecuteSelectQuery(strbSQLString.ToString)


        MiscMethods.PopulateStateComboBox(cboState)

        With dsPatient.Tables(0)
                strbSQLString.Clear()
                strbSQLString.Append("Select * from PatientRoom where Patient_TUID = " &
                                .Rows(0)(EnumList.Patient.ID))
                dsPatientRoom = CreateDatabase.ExecuteSelectQuery(strbSQLString.ToString)
                txtFirstName.Text = .Rows(0)(EnumList.Patient.FristName)
                txtLastName.Text = .Rows(0)(EnumList.Patient.LastName)
                txtEmail.Text = .Rows(0)(EnumList.Patient.Email)
                txtAddress.Text = .Rows(0)(EnumList.Patient.address)
                txtCity.Text = .Rows(0)(EnumList.Patient.City)
                txtZip.Text = .Rows(0)(EnumList.Patient.zip)
                txtDoB.Text = .Rows(0)(EnumList.Patient.DoB)
                txtPhone.Text = .Rows(0)(EnumList.Patient.Phone)
                cboStatus.Items.AddRange({"Admitted", "Discharged"})
                If .Rows(0)(EnumList.Patient.Active_Flag) = 1 Then
                    cboStatus.SelectedItem = "Admitted"
                Else
                    cboStatus.SelectedItem = "Discharged"
                End If
                cboGender.Items.AddRange({"Male", "Female"})
                If .Rows(0)(EnumList.Patient.Sex).ToString = "Male" Then
                    cboGender.SelectedItem = "Male"
                Else
                    cboGender.SelectedItem = "Female"
                End If
            PopulateRoomComboBox(cboRoom, dsRooms)
            cboRoom.SelectedItem = dsPatientRoom.Tables(0)(EnumList.PatientRoom.RoomID)

            cboState.SelectedItem = .Rows(0)(EnumList.Patient.state)
            End With
    End Sub



    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnUpdateButton_Click  	      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		              */   
    '/*		         DATE CREATED: 	2/5/2021                        	   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*	 This is going to update the patient information in the database. */
    '/*  It will create the 
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										                       */                 
    '/*             (NONE)								                   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */        
    '/*  sender – Identifies which particular control raised the          */
    '/*          click event                                              */
    '/*  e – Holds the EventArgs object sent to the routine               */  
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Private Sub btnUpdateButton_Click(sender As Object, e As EventArgs) Handles btnUpdateButton.Click
        Dim strbSQL = New StringBuilder()
        Dim status As String
        strbSQL.Append("Update Patient set ")
        strbSQL.Append("Patient_First_Name = '" & txtFirstName.Text & "', Patient_Last_Name = '" & txtLastName.Text)
        strbSQL.Append("', Date_Of_Birth = '" & txtDoB.Text & "', Sex = '" & cboGender.SelectedItem & "', Email_address = '")
        strbSQL.Append(txtEmail.Text & "', Address = '" & txtAddress.Text & "', City = '" & txtCity.Text)
        strbSQL.Append("', State = '" & cboState.SelectedItem & "', Zip_Code = '" & txtZip.Text & "', Phone_Number = '" &
                       txtPhone.Text)
        If cboStatus.SelectedItem = "Admitted" Then
            status = 1
        Else
            status = 0
        End If
        strbSQL.Append("',Active_Flag = '" & status)
        strbSQL.Append("' where Patient_ID = " & dsPatient.Tables(0).Rows(0)(EnumList.Patient.ID) & ";")

        MessageBox.Show(strbSQL.ToString)
        CreateDatabase.ExecuteInsertQuery(strbSQL.ToString)

        strbSQL.Clear()
        strbSQL.Append("Update PatientRoom set ROOM_TUID = '" & cboRoom.SelectedIndex & "' where Patient_TUID = '")
        strbSQL.Append(dsPatient.Tables(0).Rows(0)(EnumList.Patient.ID) & "';")
    End Sub
End Class