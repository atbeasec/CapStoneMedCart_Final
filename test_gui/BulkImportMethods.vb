Imports System.IO
Imports System.Net.Mail
Imports System.Text


Module BulkImportMethods
    '/*********************************************************************/
    '/*                   FILE NAME: BulkImportMethods                     */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT:	Test_gui        			   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		         */		  
    '/*		         DATE CREATED:	3/8/2021                    		   */						  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									   */			  
    '/*	 this is going to hold the methods that will handle bulk imports. */					  
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
    '/*********************************************************************/

    Const strPhonePattern As String = "^(1-)?\d{3}-\d{3}-\d{4}$"

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  importStart					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		              */   
    '/*		         DATE CREATED: 	3/8/2021	                          */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is the method that is going to kick off the bulk imports.    */ 
    '/*  it will call the other import methods that will actually do the   */
    '/*  work of importing.                                                */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 strFileName - this is the link and name of the file.             */
    '/*  strFileType - this is the tyope of file that is being imported.  */                     
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
    '/*	 srReader - this is the reader that is going to be used to read in*/
    '/*             the file.                                             */
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Public Sub importStart(strFileName As String, strFileType As String)

        Dim srReader As StreamReader = New StreamReader(strFileName)
        Select Case strFileType
            Case "patient"
                Dim PatientArray As ArrayList = ParsePatientFile(srReader)
                If Not IsNothing(PatientArray) Then
                    addPatientToDatabase(PatientArray)
                End If
            Case "physician"
                Dim PhysicianArray As ArrayList = ParsePhysicianFile(srReader)
                If Not IsNothing(PhysicianArray) Then
                    addPhysicianToDatabase(PhysicianArray)
                End If
            Case "room"
                importRoom(srReader)
            Case "user"
                importUser(srReader)
        End Select


    End Sub



    '/*********************************************************************/
    '/*                   FUNCTION NAME:  	TextCheck   				   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 3/8/2021                     		   */                             
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



    Function TextCheck(strTestStringText As String) As Boolean
        Dim blnIssue = False
        If strTestStringText.Contains(";") Then
            blnIssue = True
        End If
        Return blnIssue
    End Function

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  ParsePatientFile   			  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 	3/8/2021	                           */   
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is going to parse the patient file the user is trying to    */  
    '/*  import and will check it for errors. If there are errors it will */
    '/*  show an error message of everything wrong with file and return   */
    '/*  nothing. Other wise it will return an array list of all the      */
    '/*  records in PatientClass objects.                                 */
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
    '/*	 strbErrorMessage - this is the message that is going to be built */
    '/*                     that contains all issues with the file.       */
    '/* blnIssue - this is the boolean that tells us if there was an issue*/
    '/*            with the file and we should block the import.          */
    '/* strLine - this is the array that the text from the file is sent to*/
    '/* intLineNum - this is keeping track of what line number we are on  */
    '/*              in the file so we can tell the user where the error is*/
    '/* PatientArray - this is the arraylist that will hold all the patient*/
    '/*                 objects.                                           */
    '/* strbSQLPull - this is going to be the SQL statement that pulls back*/
    '/*               if the physician exists in the datbaase.             */
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/


    Function ParsePatientFile(srReader As StreamReader)
        Dim strLine As String()
        Dim intLineNum As Integer = 1
        Dim blnIssue = False
        Dim strbErrorMessage As StringBuilder = New StringBuilder
        Dim strbSQLPull As StringBuilder = New StringBuilder
        Dim PatientArray As ArrayList = New ArrayList()
        Do
            strLine = srReader.ReadLine.Split(vbTab)
            If Not IsNumeric(strLine(0)) Then
                blnIssue = True
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " MRN Number must be numeric")
            End If
            For i As Integer = 1 To 4
                If TextCheck(strLine(i)) Then
                    Select Case i
                        Case 1
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Barcode can not contain a ;")
                        Case 2
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Patient First Name can not contain a ;")
                        Case 3
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Patient Middle Name can not contain a ;")
                        Case 4
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Patient last name can not contain a ;")
                    End Select
                    blnIssue = True

                End If
            Next
            If Not IsDate(strLine(5)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " date of birth must be a valid date")
                blnIssue = True
            Else
                If Convert.ToDateTime(strLine(5)) > DateTime.Now Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " date of birth can not be a future date")
                    blnIssue = True
                End If
            End If
            If Not strLine(6).ToLower.Equals("male") And Not strLine(6).ToLower.Equals("female") Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Sex must be male or female")
                blnIssue = True
            End If
            If Not IsNumeric(strLine(7)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " height must be numeric")
                blnIssue = True
            End If
            If Not IsNumeric(strLine(8)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " weight must be numeric")
                blnIssue = True
            End If
            If TextCheck(strLine(9)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Address can not contain a ;")
                blnIssue = True
            End If
            If TextCheck(strLine(10)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " city can not contain a ;")
                blnIssue = True
            End If
            If Not PopulateStateComboBoxesMethod.states.Contains(strLine(11)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " state has to be a valid state")
                blnIssue = True
            End If
            Try

                Dim email = New MailAddress(strLine(12)) 'this allows .net to check
                'to see if the email is vaild. 
            Catch ex As Exception
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " email must follow a vaild email format")
                blnIssue = True
            End Try
            If IsNumeric(strLine(13)) Then
                If strLine(13).Length > 5 Or strLine(13) < 5 Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " zip code must be 5 digits long")
                    blnIssue = True
                End If
            Else
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " zip code must be numeric")
                blnIssue = True
            End If
            If Not RegularExpressions.Regex.IsMatch(strLine(14), strPhonePattern) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " phone number must follow the following format xxx-xxx-xxxx with an optional 1- at the front")
                blnIssue = True
            End If
            If Not IsNumeric(strLine(15)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician ID must be numeric and be a physciain in the system")
                blnIssue = True
            Else
                strbSQLPull.Clear()
                strbSQLPull.Append("Select count(Physician_ID) from Physician where Physician_ID = " & strLine(15))
                If CreateDatabase.ExecuteScalarQuery(strbSQLPull.ToString) < 1 Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician ID of " & strLine(15) &
                                                    " found in the system. Please use a " &
                                                    "Physician ID that is in the system.")
                    blnIssue = True
                End If
            End If
            If Not blnIssue Then
                PatientArray.Add(New PatientClass(strLine(0), strLine(1), strLine(2), strLine(3), strLine(4), strLine(5),
                                strLine(6), strLine(7), strLine(8), strLine(9), strLine(10), strLine(11), strLine(12), strLine(13),
                                strLine(14), strLine(15)))
            End If
            intLineNum += 1
        Loop While (Not srReader.EndOfStream)
        If blnIssue Then
            MessageBox.Show(strbErrorMessage.ToString)
            PatientArray.Clear()
            PatientArray = Nothing
        End If
        Return PatientArray
    End Function

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  addPatientToDatabase    	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		              */   
    '/*		         DATE CREATED: 	3/9/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is going to loop through the PatientArray and get all the   */
    '/*  patient information into a large SQL statement to the database in*/
    '/*  one shot.                                                        */
    '/*  
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 										   */                     
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


    Sub addPatientToDatabase(PatientArray As ArrayList)
        Dim strbSQLStatement As StringBuilder = New StringBuilder
        strbSQLStatement.Append("INSERT INTO Patient ('MRN_Number', 'Barcode', 'Patient_First_Name'," &
            "'Patient_Middle_Name', 'Patient_Last_Name', 'Date_of_Birth', 'Sex', 'Height', 'Weight', " &
            "'Address', 'City', 'State', 'Zip_Code', 'Phone_Number', 'Email_address', 'Primary_Physician_ID', " &
            "'Active_Flag') Values")
        For Each Patient As PatientClass In PatientArray
            With Patient
                strbSQLStatement.Append(" ('" & .MRN_Number & "', '" & checkSQLInjection(.barcode) & "', '" & checkSQLInjection(.FirstName) & "', '" & checkSQLInjection(.MiddleName) & "', '")
                strbSQLStatement.Append(checkSQLInjection(.LastName) & "', '" & .DoB & "' , '" & .sex & "', '" & .Height & "', '" & .weight & "', '")
                strbSQLStatement.Append(.Address & "', '" & .city & "', '" & .State & "', '" & .ZipCode & "', '" & .PhoneNumber & "', '")
                strbSQLStatement.Append(.email & "', '" & .PrimaryPhysicianID & "', '1'),")
            End With

        Next
        strbSQLStatement.Remove(strbSQLStatement.Length - 1, 1) 'remove the last comma
        strbSQLStatement.Append(";")
        CreateDatabase.ExecuteInsertQuery(strbSQLStatement.ToString)
        MessageBox.Show("import Finished")
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  ParsePhysicianFile 		      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 	3/8/2021	                           */   
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is going to parse the physician file the user is trying to  */  
    '/*  import and will check it for errors. If there are errors it will */
    '/*  show an error message of everything wrong with file and return   */
    '/*  nothing. Other wise it will return an array list of all the      */
    '/*  records in PhysicianClass objects.                               */
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
    '/*  RETURNS:								                           */                   
    '/*            PhysicianArray								           */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 strbErrorMessage - this is the message that is going to be built */
    '/*                     that contains all issues with the file.       */
    '/* blnIssue - this is the boolean that tells us if there was an issue*/
    '/*            with the file and we should block the import.          */
    '/* strLine - this is the array that the text from the file is sent to*/
    '/* intLineNum - this is keeping track of what line number we are on  */
    '/*              in the file so we can tell the user where the error is*/
    '/* PhysicainArray - this is the arraylist that will hold all the physcian*/
    '/*                 objects.                                           */
    '/* strbSQLPull - this is going to be the SQL statement that pulls back*/
    '/*               if the physician exists in the datbaase.             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*  NP    3/12/2021 Created the code for the function.                                                                    
    '/*********************************************************************/


    Function ParsePhysicianFile(srReader As StreamReader)
        Dim PhysicianArray As ArrayList = New ArrayList()
        Dim strLine As String()
        Dim intLineNum As Integer = 1
        Dim blnIssue = False
        Dim strbErrorMessage As StringBuilder = New StringBuilder
        Dim strbSQLPull As StringBuilder = New StringBuilder

        Do
            strLine = srReader.ReadLine.Split(vbTab)

            For i As Integer = 0 To 3
                If TextCheck(strLine(i)) Then
                    Select Case i
                        Case 0
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician First Name can not contain a ;")
                            blnIssue = True
                        Case 1
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician Middle Name can not contain a ;")
                            blnIssue = True
                        Case 2
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician Last Name can not contain a ;")
                            blnIssue = True
                        Case 3
                            strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician credentials can not contain a ;")
                            blnIssue = True
                    End Select
                End If
            Next
            If Not RegularExpressions.Regex.IsMatch(strLine(4), strPhonePattern) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " phone number must follow the following format xxx-xxx-xxxx with an optional 1- at the front")
                blnIssue = True
            End If
            If Not RegularExpressions.Regex.IsMatch(strLine(5), strPhonePattern) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " fax number must follow the following format xxx-xxx-xxxx with an optional 1- at the front")
                blnIssue = True
            End If
            If TextCheck(strLine(6)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Address can not contain a ;")
                blnIssue = True
            End If
            If TextCheck(strLine(7)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " city can not contain a ;")
                blnIssue = True
            End If
            If Not PopulateStateComboBoxesMethod.states.Contains(strLine(8)) Then
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " state has to be a valid state")
                blnIssue = True
            End If
            If IsNumeric(strLine(9)) Then
                If strLine(9).Length > 5 Or strLine(9) < 5 Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " zip code must be 5 digits long")
                    blnIssue = True
                End If
            Else
                strbErrorMessage.AppendLine("Issue on line " & intLineNum & " zip code must be numeric")
                blnIssue = True
            End If
            If Not blnIssue Then
                PhysicianArray.Add(New PhysicianClass(strLine(0), strLine(1), strLine(2), strLine(3), strLine(4),
                                        strLine(5), strLine(6), strLine(7), strLine(8), strLine(9)))
            End If
            intLineNum += 1
        Loop While (Not srReader.EndOfStream)

        If blnIssue Then
            MessageBox.Show(strbErrorMessage.ToString)
            PhysicianArray.Clear()
            PhysicianArray = Nothing
        End If
        Return PhysicianArray
    End Function




    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  addPhysicianToDatabase  	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                 */   
    '/*		         DATE CREATED:  3/12/2021                   		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
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


    Public Sub addPhysicianToDatabase(PhysicianArray As ArrayList)
        Dim strbSQLStatement As StringBuilder = New StringBuilder
        strbSQLStatement.Append("INSERT INTO Physician ('Physician_First_Name','Physician_Middle_Name',
                                'Physician_Last_Name','Physician_Credentials','Physician_Phone_Number','Physician_Fax_Number',
                                'Physician_Address','Physician_City','Physician_State','Physician_Zip_Code','Active_Flag') Values")
        For Each Physician As PhysicianClass In PhysicianArray
            With Physician
                strbSQLStatement.Append(" ('" & .FirstName & "', '" & .MiddleName & "', '" & .LastName & "', '")
                strbSQLStatement.Append(.Credentials & "', '" & .PhoneNumber & "', '" & .FaxNumber & "', '")
                strbSQLStatement.Append(.Address & "', '" & .city & "', '" & .State & "', '" & .ZipCode & "', '")
                strbSQLStatement.Append(1 & "'),")
            End With
        Next
        strbSQLStatement.Remove(strbSQLStatement.Length - 1, 1) 'remove the last comma
        strbSQLStatement.Append(";")
        CreateDatabase.ExecuteInsertQuery(strbSQLStatement.ToString)
        MessageBox.Show("import Finished")
    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  importUser  				  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 	3/8/2021	                           */   
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
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


    Sub importUser(srReader As StreamReader)

    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: importRoom					  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 	3/8/2021	                           */   
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
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


    Sub importRoom(srReader As StreamReader)

    End Sub

End Module
