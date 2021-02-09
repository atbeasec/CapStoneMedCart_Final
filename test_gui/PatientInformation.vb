Imports System.Data.SQLite
Module PatientInformation
    '/*******************************************************************/
    '/*                   FILE NAME: PatientInformation.vb              */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module is  reponsible for populating the patient           */
    '/* information boxes, patient first, and last name, patient MRN,   */
    '/* DOB, sex, height, weight, room number, bed number, the patient's*/
    '/* primary physician, and the patients address email and           */
    '/* phone number into the patient information form.                 */
    '/* it is also responsible for displaying the current and past      */
    '/* medication history of the patient, along with displaying patient*/
    '/* allergies and patient chart notes.                              */
    '/*ALL patient information will be imported from the database into a*/ 
    '/*list which will Then populate the tables Of data On the patient  */ 
    '/*information view                                                 */
    '/*                                                                 */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                         (NONE)	                                */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                        (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* the program will invoke this module when a patient chart is     */
    '/* loaded to populate the selected patients information fields.     */
    '/*******************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                */
    '/*						  	 (NONE)			                        */
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
    '/*  WHO                     WHEN        WHAT						*/
    '/*  Alexander Beasecker    1/25/2021   Initial creation            */
    '/*  Adam Kott              1/27/2021   added plans for module      */
    '/*  Adam Kott              1/28/2021   added database connection   */
    '/*******************************************************************/


    Public Sub GetPatientInformation(ByRef intPatientMRN As Integer)

        Dim dsPatientDataSet As DataSet = New DataSet
        Dim intPhysicianID As String
        Dim strSQLiteCommand As String = "SELECT MRN_Number, Patient_First_Name,Patient_Middle_Name, Patient_Last_Name, " &
            "Date_of_Birth, Sex, Height, Weight, Address, City, State, Email_address, Phone_Number, Primary_Physician_ID " &
            " FROM Patient WHERE MRN_Number = '" & intPatientMRN & "'"

        dsPatientDataSet = CreateDatabase.ExecuteSelectQuery(strSQLiteCommand)

        For Each dr As DataRow In dsPatientDataSet.Tables(0).Rows

            If IsDBNull(dr(0)) Then
                frmPatientInfo.txtMRN.Text = "N/A"
            Else
                frmPatientInfo.txtMRN.Text = dr(0)
            End If

            If IsDBNull(dr(4)) Then
                frmPatientInfo.txtBirthday.Text = "N/A"
            Else
                frmPatientInfo.txtBirthday.Text = dr(4)
            End If

            If IsDBNull(dr(5)) Then
                frmPatientInfo.txtGender.Text = "N/A"
            Else
                frmPatientInfo.txtGender.Text = dr(5)
            End If

            If IsDBNull(dr(6)) Then
                frmPatientInfo.txtHeight.Text = "N/A"
            Else
                frmPatientInfo.txtHeight.Text = dr(6)
            End If

            If IsDBNull(dr(7)) Then
                frmPatientInfo.txtWeight.Text = "N/A"
            Else
                frmPatientInfo.txtWeight.Text = dr(7)
            End If

            If IsDBNull(dr(8)) Then
                frmPatientInfo.txtAddress.Text = "N/A"
            Else
                frmPatientInfo.txtAddress.Text = dr(8) & " " & dr(9) & " " & dr(10)
            End If

            If IsDBNull(dr(11)) Then
                frmPatientInfo.txtEmail.Text = "N/A"
            Else
                frmPatientInfo.txtEmail.Text = dr(11)
            End If

            If IsDBNull(dr(12)) Then
                frmPatientInfo.txtPhone.Text = "N/A"
            Else
                frmPatientInfo.txtPhone.Text = dr(12)
            End If

            If IsDBNull(dr(1)) Then
                frmPatientInfo.LblPatientName.Text = "N/A"
            Else
                frmPatientInfo.LblPatientName.Text = dr(1) & " " & dr(2) & " " & dr(3)
            End If

            intPhysicianID = dr(13)
        Next

        strSQLiteCommand = "SELECT Physician_First_Name,Physician_Last_Name" &
            " FROM Physician WHERE Physician_ID = '" & intPhysicianID & "'"

        dsPatientDataSet = CreateDatabase.ExecuteSelectQuery(strSQLiteCommand)

        For Each dr As DataRow In dsPatientDataSet.Tables(0).Rows
            If IsDBNull(dr(1)) Then
                frmPatientInfo.txtPhysician.Text = "N/A"
            Else
                frmPatientInfo.txtPhysician.Text = "Dr. " & dr(0) & " " & dr(1)
            End If
        Next

        DispenseHistory.DispenseHistorySpecificPatient(intPatientMRN)
    End Sub

End Module