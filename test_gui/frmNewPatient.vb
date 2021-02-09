Imports System.Text
Public Class frmNewPatient
    '/*********************************************************************/
    '/*                   FILE NAME:  */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT:				   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		         */		  
    '/*		         DATE CREATED:			   */						  
    '/*********************************************************************/
    '/*  PROJECT PURPOSE:								   */				  
    '/*											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									   */			  
    '/*											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			   */ 
    '/*                                                    (NONE)	   */	  
    '/*********************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							   */			  
    '/*                          (NOTHING)					   */		  
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */			  
    '/*											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			         */		  
    '/*						  	 (NONE)			   */					  
    '/*********************************************************************/
    '/* COMPILATION NOTES(will include version notes including libraries):*/
    '/* 											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */				  
    '/*											   */					  
    '/*  WHO   WHEN     WHAT								   */			  
    '/*  ---   ----     ------------------------------------------------- */
    '/*  NP    2/6/2021 Started to connect the GUI to the database. 
    '/*********************************************************************/


    Dim dsrooms As DataSet
    Dim dsPhysicians As DataSet
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SavePatientDataToDatabase()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  SavePatientDataToDatabase	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		           */   
    '/*		         DATE CREATED: 	2/6/2021                        	   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*											   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*											   */                     
    '/*                                                                     
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


    Private Sub SavePatientDataToDatabase()
        Dim strbSQL As New StringBuilder()
        Dim strPhysicianName As String() = Split(cmbPhysician.SelectedItem)
        dsPhysicians = CreateDatabase.ExecuteSelectQuery("Select Physician_ID from  Physician where Physician_First_name = '" &
                                                         strPhysicianName(0) & "' and Physician_Last_Name = '" &
                                                         strPhysicianName(1) & "';")



        'grab data from all textfields and send it to the database

        strbSQL.Append("INSERT INTO Patient ('MRN_Number', 'Barcode', 'Patient_First_Name'," &
            "'Patient_Middle_Name', 'Patient_Last_Name', 'Date_of_Birth', 'Sex', 'Height', 'Weight', " &
            "'Address', 'City', 'State', 'Zip_Code', 'Phone_Number', 'Email_address', 'Primary_Physician_ID', " &
            "'Active_Flag') Values ('")

        strbSQL.Append(CInt(Rnd() * 20) & "','")
        strbSQL.Append(CInt(Rnd() * 20) & "',") 'this is going to make a random barcode this is temporary
        strbSQL.Append("'" & txtFirstName.Text & "' , '" & txtMiddleName.Text & "',")
        strbSQL.Append("'" & txtLastName.Text & "','" & txtBirthday.Text & "',")
        strbSQL.Append("'" & cmbSex.SelectedItem & "','" & txtHeight.Text & "',")
        strbSQL.Append("'" & txtWeight.Text & "','" & txtAddress.Text & "',")
        strbSQL.Append("'" & txtCity.Text & "','" & cmbState.SelectedItem & "',")
        strbSQL.Append("'" & txtZipCode.Text & "','" & txtPhoneNumber.Text & "',")
        strbSQL.Append("'" & txtEmail.Text & "','" & dsPhysicians.Tables(0).Rows(0)(EnumList.Physician.Id) & "',")
        strbSQL.Append("'" & 1 & "');")

        CreateDatabase.ExecuteInsertQuery(strbSQL.ToString)
        'send message saying it was a success or error

        'if error say what the error was and return to the form with the filled out info

        ' Else

        ' success message that the data was saved to the database successfully
    End Sub

    '/*********************************************************************/
    '/*                   SUBPRORAM NAME:  frmNewPatient_Load		       */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		            */   
    '/*		         DATE CREATED: 	2/6/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGAM PURPOSE:								   */             
    '/*	 This is going to run before the form is shown. It is going to    */                     
    '/*  populate the combo boxes.                                        */
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

    Private Sub frmNewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsrooms = CreateDatabase.ExecuteSelectQuery("Select * From Rooms ORDER BY Room_ID, Bed_Name;")
        dsPhysicians = CreateDatabase.ExecuteSelectQuery("Select * from Physician ORDER BY Physician_First_Name;")
        cmbSex.Items.AddRange({"Male", "Female"})
        PopulateStateComboBox(cmbState)
        PopulateRoomComboBox(cmbRoom, dsrooms)
        populateBedComboBox(cmbBed, dsrooms)
        populatePhysicianComboBox(cmbPhysician, dsPhysicians)
    End Sub


End Class