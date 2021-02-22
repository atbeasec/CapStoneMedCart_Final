Imports System.ComponentModel
Imports System.Net.Mail
Imports System.Text
Imports System.Text.RegularExpressions
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
    '/*  NP    2/21/2021 added the error checking call to the save button.*/
    '/*********************************************************************/


    Dim dsrooms As DataSet
    Dim dsPhysicians As DataSet
    Dim strAllowedNameCharacters = "abcdefghijklmnopqrstuvwxyz '-1234567890!@#$%^&*()/.,<>=+"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not hasError() Then
            SavePatientDataToDatabase()
            Me.Close()
        End If



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
    '/*	strAddress - this is going to hold the result of txtAddress.text  */
    '/*              after all the ' have been escaped.                   */
    '/* strbSQL - this is the string builder that is used to construct the*/
    '/*           the SQL command.                                        */
    '/* strCharactersForRandomGeneration - this is the string that is used*/
    '/*          to randomly generate a string.                           */
    '/* strCity - this is going ot hold the result of txtCity.text after  */
    '/*           the ' have been escaped.                                *.
    '/* strEmail - this is going to hold the result of txtemail.text after*/
    '/*            the ' are escaped.                                     */
    '/* strFirstName - This is going to hold the result of txtFirstName.text*/
    '/*                after all the ' are escaped.                       */
    '/* strLastName - this is going to hold the result of txtLastName.text*/
    '/*               after all the ' have been escaped.                  */
    '/* strMiddleName - this is going to hold the result of txtMiddleName.text*/
    '/*                 after the ' have been escaped.                    */
    '/* strPhysicianName - this used to remove teh trailing , in the selection*/
    '/*                    of the combo box.                              */
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
    '/* NP     2/22/2021 added the ability to have ' in the name and email. */   
    '/*********************************************************************/


    Private Sub SavePatientDataToDatabase()
        Dim strbSQL As New StringBuilder()
        Dim strPhysicianName As String() = Split(cmbPhysician.SelectedItem)
        Dim strCharactersForRandomGeneration = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        'the following is just to escape the ' so that it won't break the SQL
        Dim strFirstName = Regex.Replace(txtFirstName.Text, "'", "''")
        Dim strMiddleName = Regex.Replace(txtMiddleName.Text, "'", "''")
        Dim strLastName = Regex.Replace(txtLastName.Text, "'", "''")
        Dim strEmail = Regex.Replace(txtEmail.Text, "'", "''")
        Dim strAddress = Regex.Replace(txtAddress.Text, "'", "''")
        Dim strCity = Regex.Replace(txtCity.Text, "'", "''")

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
        strbSQL.Append(GenerateRandom.generateRandomAlphanumeric(20, "1234567890") & "','")
        '^this is going to generate a random MRN number
        strbSQL.Append(GenerateRandom.generateRandomAlphanumeric(20, strCharactersForRandomGeneration) & "',")
        '^this is going to genereate a random Bar code. 
        strbSQL.Append("'" & strFirstName & "' , '" & strMiddleName & "',")
        strbSQL.Append("'" & strLastName & "','" & mtbDoB.Text & "',")
        strbSQL.Append("'" & cmbSex.SelectedItem & "','" & txtHeight.Text & "',")
        strbSQL.Append("'" & txtWeight.Text & "','" & strAddress & "',")
        strbSQL.Append("'" & strCity & "','" & cmbState.SelectedItem & "',")
        strbSQL.Append("'" & txtZipCode.Text & "','" & mtbPhone.Text & "',")
        strbSQL.Append("'" & strEmail & "','" & dsPhysicians.Tables(0).Rows(0)(EnumList.Physician.Id) & "',")
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
    '/*                   SUBPROGRAM NAME: cmbSex_KeyPress  			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
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

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtHeight_KeyPress   		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  txtWeight_KeyPress  		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtFirstName_KeyPress		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        DataVaildationMethods.KeyPressCheck(e, strAllowedNameCharacters)
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtMiddleName_KeyPress		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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

    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        DataVaildationMethods.KeyPressCheck(e, strAllowedNameCharacters)
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtLastName_KeyPress 		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        DataVaildationMethods.KeyPressCheck(e, strAllowedNameCharacters)
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtAddress_KeyPress 	           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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




    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz 0123456789.'-#@%&/")
    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: cmbState_KeyPress 	           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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


    Private Sub cmbState_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbState.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz")



    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtCity_KeyPress 	           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								              */             
    '/*	 This is going to check the keys that are pressed. All it does it */
    '/*  is call the keypresscheck fucntion.                              */
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

    Private Sub txtCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz 0123456789.'-#@%&/")
    End Sub



    '/*********************************************************************/
    '/*                   FUNCTION NAME:  hasError  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/21/2021	                           */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*	 This is going to check the input boxes on the form to make sure that*/                     
    '/*  there is information in the boxes. Most of the textboxes lock the */
    '/*  characters that are allowed in them so we just need to check to see*/
    '/*  if there are values in the boxes.                                 */
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
    '/*	 email - this is a test value to see if the email is valid.       */	
    '/*  strbErrorMessage- This is the string builder that will be used to*/
    '/*                    display the build error message based on what is*/
    '/*                    missing on the form.                           */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Function hasError() As Boolean
        Dim strbErrorMessage As New StringBuilder
        Dim email As MailAddress
        hasError = False
        If txtFirstName.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid first name." & vbCrLf)
        End If
        If txtMiddleName.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid middle name." & vbCrLf)
        End If
        If txtLastName.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid last name." & vbCrLf)
        End If
        Try
            email = New MailAddress(txtEmail.Text) 'this allows .net to check
            'to see if the email is vaild. 

        Catch ex As Exception
            hasError = True
            strbErrorMessage.Append("Please Enter a valid email address." & vbCrLf)
        End Try
        If cmbSex.SelectedIndex = -1 Then
            hasError = True
            strbErrorMessage.Append("Please select male or female for the patient sex." & vbCrLf)
        End If
        If Not IsDate(mtbDoB.Text) Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid date of birth." & vbCrLf)
        End If
        If txtHeight.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid height." & vbCrLf)
        End If
        If txtWeight.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid weight." & vbCrLf)
        End If
        If cmbRoom.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid room." & vbCrLf)
        End If
        If cmbBed.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid bed name." & vbCrLf)
        End If
        If txtAddress.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid street address." & vbCrLf)
        End If
        If txtCity.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid city name." & vbCrLf)
        End If
        If cmbState.SelectedIndex = -1 Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid state." & vbCrLf)
        End If
        If txtZipCode.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid zip code" & vbCrLf)
        End If
        If mtbPhone.Text = String.Empty Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid phone number." & vbCrLf)
        End If
        If cmbPhysician.SelectedIndex = -1 Then
            hasError = True
            strbErrorMessage.Append("Please enter a valid physician name." & vbCrLf)
        End If
        If hasError Then
            MessageBox.Show(strbErrorMessage.ToString)
        End If
        Return hasError
    End Function
End Class