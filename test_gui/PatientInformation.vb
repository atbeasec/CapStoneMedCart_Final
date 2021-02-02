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

    'create variables and classes to store information to
    'dataset? class? list?

    Public Class Patient
        Dim strMRN As String

    End Class
    Dim lstPatients As New List Of clsPatients
    'create database connection string
    ' Dim strDEFAULTFOLDER As String = "C:\"
    Dim strDBNAME As String = "Medication Cart System"
    Dim strDBPath As String = strDEFAULTFOLDER & strDBNAME & ".db"

    Public DBConn As New SQLite.SQLiteConnection()
    Public DBCmd As SQLite.SQLiteCommand
    Public strDBConnString As String = String.Format("Data Source = {0}", strDBPath)

    Dim myConnection As SQLiteConnection = New SQLiteConnection()
    myConnection.ConnectionString = strDBConnString
        myConnection.Open()

    Dim DBAdaptPatient As SqlDataAdapter
    Dim DBAdaptPhysician As SqlDataAdapter

    'call for all information from database
        strSQlliteCmd = "Select * FROM Patient"
        DBAdaptPatient = New SqlDataAdapter(SQlliteCmd, strDBConnString)
        'DBAdaptPets.Fill(dsPatients, "Patients")

        'dgvPetsDataView.DataSource = dsPets.Tables("Pets")

    'store all information into a list of patient classes

    'display all information to tables in GUI

    'have seperate class, in module or not? just create list of objects in here?


End Module