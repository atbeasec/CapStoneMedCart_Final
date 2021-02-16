Imports System.Data.SQLite
Imports System.Text
Imports System.Security.Cryptography

Module LogIn
    '/*******************************************************************/
    '/*                   FILE NAME:  LogIn.vb                          */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  Dylan Walter  		            */
    '/*		         DATE CREATED: January 31, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* Check entered Loggin information with records in the database   */
    '/* change the variable concernering access level the user has.     */
    '/*                                                                 */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                                                    (NONE)	    */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                          (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* the program will invoke this module on a user logging into the  */
    '/* the system.                                                     */
    '/*******************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                */
    '/*  AccessLevel                                                    */
    '/*  UserName                                                       */
    '/*******************************************************************/
    '/* COMPILATION NOTES:								                */
    '/* 											                    */
    '/* This project compiles normally under Microsoft Visual Basic.    */
    '/* All one needs to do Is open up the Solver project And compile.  */
    '/* No special compile options Or optimizations were used.  No      */
    '/* unresolved warnings Or errors exist under these compilation     */
    '/* conditions.									                    */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:						                    */
    '/*											                        */
    '/*  WHO             WHEN        WHAT								*/
    '/*  Dylan Walter    1/31/2021   Initial creation                   */
    '/*	 Dylan Walter    2/3/2021	 Added ScanLogin and UsernameLogin  */
    '/*******************************************************************/
    Public Function ScanLogIn(ByVal strBarcode As String)

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        'open a file reader and read in the database location
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("config.app")


        ' create a new database connection:
        sqlite_conn = New SQLiteConnection("Data Source=" & fileReader & ";")

        ' open the connection:
        sqlite_conn.Open()

        sqlite_cmd = sqlite_conn.CreateCommand()

        'Search the table for the barcode
        sqlite_cmd.CommandText = "SELECT COUNT(*) FROM User WHERE Barcode = '" & strBarcode & "'"
        sqlite_cmd.ExecuteNonQuery()
        'If there is a user with that Barcode in the user database then log them in and continue to Form1
        If sqlite_cmd.ExecuteScalar <> 0 Then
            Return "True"
        Else
            Return "False"
        End If
        sqlite_conn.Close()
    End Function

    Public Function UsernameLogIn(ByVal strUsername As String, ByVal strPassword As String)
        ' hash the password and add the pepper
        strPassword = AddSaltPepperAndHash(strPassword, strUsername)

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand

        'open a file reader and read in the database location
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("config.app")


        ' create a new database connection:
        sqlite_conn = New SQLiteConnection("Data Source=" & fileReader & ";")

        ' open the connection:
        sqlite_conn.Open()

        sqlite_cmd = sqlite_conn.CreateCommand()

        'Search the table for the Username and Password
        sqlite_cmd.CommandText = "SELECT COUNT(*) FROM User WHERE Username = '" & strUsername & "'" & " AND Password = '" & strPassword & "'"
        sqlite_cmd.ExecuteNonQuery()
        'If there is a user with that Barcode in the user database then log them in and continue to Form1
        If sqlite_cmd.ExecuteScalar <> 0 Then
            Return "True"
        Else
            Return "False"
        End If
        sqlite_conn.Close()
    End Function

    Public Function AddSaltPepperAndHash(ByVal strPassword As String, ByVal strUsername As String) As String
        ' This function is to get the salt and pepper added to a password input for login and return it to be verified against the database
        Dim strHashedSaltedPepperedPassword As String = Nothing
        Dim strSalt As String
        ' create a pepper for the hashing to add to the password
        Const STRPEPPER As String = "aBcEasyas123"
        ' add the pepper to the password
        strPassword = strPassword & STRPEPPER
        ' retrieve the salt from the database
        Dim strQuery = "SELECT Salt FROM USER WHERE Username = '" & strUsername & "'"
        strSalt = ExecuteScalarQuery(strQuery)
        ' add the salt to the password prepended
        strPassword = strSalt & strPassword
        ' get the hash of the byte array
        strHashedSaltedPepperedPassword = EncryptString(strPassword)
        ' return the hashed, saleted and peppered password
        Return strHashedSaltedPepperedPassword
    End Function

    Public Function MakeSaltPepperAndHash(ByVal strPassword As String) As String()
        ' This function is to make the salt and add it and the pepper to a password input for a new user and to add it to the database
        ' It returns an array of strings where O is the salted, peppered, hashed password and 1 is the salt
        Const STRSALTCHARS As String = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim strHashedSaltedPepperedPassword(2) As String
        Dim strUpdatedPassword As String
        Dim strSalt As String = ""
        ' create a pepper for the hashing to add to the password
        Const STRPEPPER As String = "aBcEasyas123"

        ' add the pepper to the password
        strUpdatedPassword = strPassword & STRPEPPER
        ' generate a random salt
        For i = 0 To (7) Step 1
            Dim intCharPosition = CInt(Rnd() * (Rnd()) * Rnd() * 61)
            strSalt += STRSALTCHARS.ToCharArray.ElementAt(intCharPosition)
        Next
        ' add the salt to the password prepended
        'strTemp = EncryptString(strUpdatedPassword)
        strUpdatedPassword = strSalt & strUpdatedPassword
        strHashedSaltedPepperedPassword(0) = EncryptString(strUpdatedPassword)
        ' save the salt to the return
        strHashedSaltedPepperedPassword(1) = strSalt.ToString
        ' return the hashed, saleted and peppered password
        Return strHashedSaltedPepperedPassword
    End Function

    Private Function EncryptString(str As String) As String
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed As Byte() = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function

End Module
