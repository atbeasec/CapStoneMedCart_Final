Imports System.ComponentModel
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
    '/*  NP    2/20/2021 Added datavaildation for the texboxs on the form.*/
    '/*********************************************************************/


    Dim dsrooms As DataSet
    Dim dsPhysicians As DataSet
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SavePatientDataToDatabase()

        Me.Close()
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
    '/*  NP    2/18/2021 Swapped the numbers of strPhysiciansName() because*/
    '/*                 They were inverted and were breaking the app. I also*/
    '/*                 made it so the comma is trimed off the last name of */
    '/*                 the physician.                                      */
    '/*********************************************************************/


    Private Sub SavePatientDataToDatabase()
        Dim strbSQL As New StringBuilder()
        Dim strPhysicianName As String() = Split(cmbPhysician.SelectedItem)
        Dim strCharactersForRandomGeneration = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        strPhysicianName(0) = strPhysicianName(0).TrimEnd(",")
        dsPhysicians = CreateDatabase.ExecuteSelectQuery("Select Physician_ID from  Physician where Physician_First_name = '" &
                                                         strPhysicianName(1) & "' and Physician_Last_Name = '" &
                                                         strPhysicianName(0) & "';")



        'grab data from all textfields and send it to the database

        strbSQL.Append("INSERT INTO Patient ('MRN_Number', 'Barcode', 'Patient_First_Name'," &
            "'Patient_Middle_Name', 'Patient_Last_Name', 'Date_of_Birth', 'Sex', 'Height', 'Weight', " &
            "'Address', 'City', 'State', 'Zip_Code', 'Phone_Number', 'Email_address', 'Primary_Physician_ID', " &
            "'Active_Flag') Values ('")

        'strbSQL.Append(CInt(Rnd() * 20) & "','")
        'strbSQL.Append(CInt(Rnd() * 20) & "',") 'this is going to make a random barcode this is temporary
        strbSQL.Append(GenerateRandom.generateRandomAlphanumeric(20, strCharactersForRandomGeneration) & "','")
        '^this is going to generate a random MRN number
        strbSQL.Append(GenerateRandom.generateRandomAlphanumeric(20, strCharactersForRandomGeneration) & "',")
        '^this is going to genereate a random Bar code. 
        strbSQL.Append("'" & txtFirstName.Text & "' , '" & txtMiddleName.Text & "',")
        strbSQL.Append("'" & txtLastName.Text & "','" & mtbDoB.Text & "',")
        strbSQL.Append("'" & cmbSex.SelectedItem & "','" & txtHeight.Text & "',")
        strbSQL.Append("'" & txtWeight.Text & "','" & txtAddress.Text & "',")
        strbSQL.Append("'" & txtCity.Text & "','" & cmbState.SelectedItem & "',")
        strbSQL.Append("'" & txtZipCode.Text & "','" & mtbPhone.Text & "',")
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
        dsrooms = CreateDatabase.ExecuteSelectQuery("Select * From Rooms where Active_flag = '" & 1 & "' ORDER BY Room_ID, Bed_Name;")
        dsPhysicians = CreateDatabase.ExecuteSelectQuery("Select * from Physician where Active_flag = '" & 1 & "' ORDER BY Physician_Last_Name, Physician_First_Name ;")
        cmbSex.Items.AddRange({"Male", "Female"})
        PopulateStateComboBox(cmbState)
        PopulateRoomComboBox(cmbRoom, dsrooms)
        populateBedComboBox(cmbBed, dsrooms)
        populatePhysicianComboBox(cmbPhysician, dsPhysicians)

        cmbBed.Enabled = False
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  cmbRoom_SelectedIndexChanged  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/20/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								             */             
    '/*	 This Repopulated the bed combo box based on what was selected for */
    '/*   the room. It does this by calling the updateBedComboBox method.  */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
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


    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged

        PopulateRoomsCombBoxesMethods.UpdateBedComboBox(cmbBed, cmbRoom)
        cmbBed.Enabled = True
    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtZipCode_KeyPress  		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                */   
    '/*		         DATE CREATED: 2/20/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								               */             
    '/*	 This is going to check all the key pressed to make sure that they */                     
    '/*  are numeric. All it does is call the keypressCheck method to do this*/
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
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

    Private Sub txtZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZipCode.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  mtbDoB_LostFocus    		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                */   
    '/*		         DATE CREATED: 	2/20/2021                          	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:	            							   */             
    '/*	 This is going to make sure the date that has been entered into the*/                     
    '/*  maskedtextbox is a valid date. If not it will problem the user to */
    '/*  re enter the date.                                                */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
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


    Private Sub mtbDoB_LostFocus(sender As Object, e As EventArgs) Handles mtbDoB.LostFocus
        If ActiveControl.Name = "cmbSex" Then
            'this was put in place so if the user is being bounced back to
            'cmbSex the error checking doesn't fire. 
        Else
            If Not ActiveControl.Name = "btnCancel" Then
                'If Not (IsDate(mtbDoB.Text)) Then
                '    mtbDoB.Clear()
                '    MessageBox.Show("Date Of Birth must contain a vaild date.")
                '    mtbDoB.Focus()
                'End If
            End If
        End If
    End Sub







    'Private Sub mtbDoB_Validating(sender As Object, e As CancelEventArgs) Handles mtbDoB.Validating
    '    If Not (IsDate(mtbDoB.Text)) Then

    '        ErrorProvider1.SetError(Me.mtbDoB, "Date Of Birth must contain a vaild date.")
    '        e.Cancel = True

    '    Else
    '        ErrorProvider1.SetError(Me.mtbDoB, String.Empty)
    '    End If
    'End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: cmbSex_KeyPress  			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:							            	   */             
    '/*	 This is checking what the user is typing in to auto fill the combo*/                     
    '/*  box selection.                                                    */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
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

    Private Sub cmbSex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSex.KeyPress
        If String.Equals(e.KeyChar, "m", StringComparison.InvariantCultureIgnoreCase) Then
            e.Handled = True
            cmbSex.Text = String.Empty
            cmbSex.SelectedItem = "Male"
        ElseIf String.Equals(e.KeyChar, "f", StringComparison.InvariantCultureIgnoreCase) Then
            e.Handled = True
            cmbSex.Text = String.Empty
            cmbSex.SelectedItem = "Female"
        Else
            e.Handled = True
            cmbSex.Text = String.Empty
        End If
    End Sub

    Private Sub cmbSex_LostFocus(sender As Object, e As EventArgs) Handles cmbSex.LostFocus
        If Not ActiveControl.Name = "btnCancel" Then

        End If
    End Sub

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
    End Sub




    'Private Sub cmbSex_Validating(sender As Object, e As CancelEventArgs) Handles cmbSex.Validating
    '    If Not cmbSex.SelectedItem = "Male" And Not cmbSex.SelectedItem = "Female" Then
    '        Me.ErrorProvider1.SetError(Me.cmbSex, "Please select Male or Female for the Patient Sex")
    '        e.Cancel = True
    '        'MessageBox.Show("")
    '        'cmbSex.Focus()
    '    Else
    '        ErrorProvider1.SetError(cmbSex, "")
    '    End If
    'End Sub


End Class