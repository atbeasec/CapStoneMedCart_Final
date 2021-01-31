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
    '/*******************************************************************/
    Public Sub ScanLogIn(ByVal Barcode As Integer)
        MessageBox.Show("Barcode number entered is" + Str(Barcode))
    End Sub

End Module
