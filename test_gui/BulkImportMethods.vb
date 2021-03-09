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
                ImportPatient(srReader)
            Case "physician"
                importPhysician(srReader)
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
    '/*                   SUBPROGRAM NAME:  ImportPatient   			  */         
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

    Sub ImportPatient(srReader As StreamReader)
        Dim strLine As String()
        Dim intLineNum As Integer = 1
        Dim blnIssue = False
        Dim strbErrorMessage As StringBuilder = New StringBuilder
        Dim strbSQLPull As StringBuilder = New StringBuilder
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
                End If
                If Not IsDate(strLine(5)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " date of birth must be a valid date")
                Else
                    If Convert.ToDateTime(strLine(5)) > DateTime.Now Then
                        strbErrorMessage.AppendLine("Issue on line " & intLineNum & " date of birth can not be a future date")
                    End If
                End If
                If Not strLine(6).ToLower.Equals("male") And Not strLine(6).ToLower.Equals("female") Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Sex must be male or female")
                End If
                If Not IsNumeric(strLine(7)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " height must be numeric")
                End If
                If Not IsNumeric(strLine(8)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " weight must be numeric")
                End If
                If TextCheck(strLine(9)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Address can not contain a ;")
                End If
                If TextCheck(strLine(10)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " city can not contain a ;")
                End If
                If Not PopulateStateComboBoxesMethod.states.Contains(strLine(11)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " state has to be a valid state")
                End If
                Try

                    Dim email = New MailAddress(strLine(12)) 'this allows .net to check
                    'to see if the email is vaild. 
                Catch ex As Exception
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " email must follow a vaild email format")
                End Try
                If IsNumeric(strLine(13)) Then
                    If strLine(13).Length > 5 Or strLine(13) < 5 Then
                        strbErrorMessage.AppendLine("Issue on line " & intLineNum & " zip code must be 5 digits long")
                    End If
                Else
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " zip code must be numeric")
                End If
                If Not RegularExpressions.Regex.IsMatch(strLine(14), "^(1-)?\d{3}-\d{3}-\d{4}$") Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " phone number must follow the following format xxx-xxx-xxxx with an optional 1- at the front")
                End If
                If Not IsNumeric(strLine(15)) Then
                    strbErrorMessage.AppendLine("Issue on line " & intLineNum & " Physician ID must be numeric and be a physciain in the system")
                Else
                    strbSQLPull.Clear()
                    strbSQLPull.Append("Select count(Physician_ID) from Physician where Physician_ID = " & strLine(15))
                    If CreateDatabase.ExecuteScalarQuery(strbSQLPull.ToString) < 1 Then
                        strbErrorMessage.AppendLine("Issue on line " * intLineNum & " Physician ID of " & strLine(15) &
                                                    "found in the system. Please a " &
                                                    "Physician ID that is in the system.")
                    End If
                End If
            Next
            intLineNum += 1
        Loop While (Not srReader.EndOfStream)
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  importPhysician 		      */         
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


    Sub importPhysician(srReader As StreamReader)

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
