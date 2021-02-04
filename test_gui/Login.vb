Imports System.Data.SQLite

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

End Module
