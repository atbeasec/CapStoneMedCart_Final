﻿Public Class frmSerialPort

    Private Sub frmSerialPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmCart = New frmFullCart()
        AddItemsToBaudrate()
        AddItemsToComPort()
        frmCart.gettingConnectionSettings() ' this is going to get the information from the database. 
        cmbBaudrate.SelectedItem = frmCart.bitRate.ToString
        cmbComPort.SelectedItem = frmCart.comPort
        If CartInterfaceCode.blnSimulationMode Then
            chkSimulation.Checked = True
        Else
            chkSimulation.Checked = False
        End If



    End Sub

    Private Sub AddItemsToBaudrate()

        Const INTBAUDRATEONE As Integer = 300
        Const INTBAUDRATETWO As Integer = 600
        Const INTBAUDRATETHREE As Integer = 1200
        Const INTBAUDRATEFOUR As Integer = 2400
        Const INTBAUDRATEFIVE As Integer = 4800
        Const INTBAUDRATESIX As Integer = 9600
        Const INTBAUDRATESEVEN As Integer = 14400
        Const INTBAUDRATEEIGHT As Integer = 19200
        Const INTBAUDRATENINE As Integer = 38400
        Const INTBAUDRATETEN As Integer = 57600
        Const INTBAUDRATEELEVEN As Integer = 115200
        Const INTBAUDRATETWELVE As Integer = 230400
        Const INTBAUDRATETHIRTEEN As Integer = 460800

        cmbBaudrate.Items.Add(INTBAUDRATEONE)
        cmbBaudrate.Items.Add(INTBAUDRATETWO)
        cmbBaudrate.Items.Add(INTBAUDRATETHREE)
        cmbBaudrate.Items.Add(INTBAUDRATEFOUR)
        cmbBaudrate.Items.Add(INTBAUDRATEFIVE)
        cmbBaudrate.Items.Add(INTBAUDRATESIX)
        cmbBaudrate.Items.Add(INTBAUDRATESEVEN)
        cmbBaudrate.Items.Add(INTBAUDRATEEIGHT)
        cmbBaudrate.Items.Add(INTBAUDRATENINE)
        cmbBaudrate.Items.Add(INTBAUDRATETEN)
        cmbBaudrate.Items.Add(INTBAUDRATEELEVEN)
        cmbBaudrate.Items.Add(INTBAUDRATETWELVE)
        cmbBaudrate.Items.Add(INTBAUDRATETHIRTEEN)


        '
        '
        '
        '

        ' do SQL query to have the one from the database selected in the combo box

    End Sub

    Private Sub AddItemsToComPort()

        Const STRCOMPORTONE As String = "COM1"
        Const STRCOMPORTTWO As String = "COM2"
        Const STRCOMPORTTHREE As String = "COM3"
        Const STRCOMPORTFOUR As String = "COM4"
        Const STRCOMPORTFIVE As String = "COM5"
        Const STRCOMPORTSIX As String = "COM6"
        Const STRCOMPORTSEVEN As String = "COM7"

        cmbComPort.Items.Add(STRCOMPORTONE)
        cmbComPort.Items.Add(STRCOMPORTTWO)
        cmbComPort.Items.Add(STRCOMPORTTHREE)
        cmbComPort.Items.Add(STRCOMPORTFOUR)
        cmbComPort.Items.Add(STRCOMPORTFIVE)
        cmbComPort.Items.Add(STRCOMPORTSIX)
        cmbComPort.Items.Add(STRCOMPORTSEVEN)



        '
        '
        '
        '

        ' do SQL query to have the one from the database selected in the combo box

    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnSave_Click    			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/12/2021	                           */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								               */             
    '/*	 This is going to handle when the user clicks the save button.    */
    '/*  It is going to call the changeSettings method in CartInterfaceCode*/
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										                     */                 
    '/*  cartInterfaceCode.changeSettings()		    					   */             
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
    '/*	 blnSim - this is going to indicate if the check box is checked   */ 
    '/*           or not.                                                 */
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'call code to extract the values from the combo boxes and overwite the current values in database
        Dim blnSim As Boolean

        If chkSimulation.Checked Then
            blnSim = True
        Else
            blnSim = False
        End If

        CartInterfaceCode.ChangeSettings(cmbBaudrate.SelectedItem, cmbComPort.SelectedItem, blnSim)
        MessageBox.Show("New settings have been saved.")
    End Sub

    Private Sub btnExportDatabase_Click(sender As Object, e As EventArgs) Handles btnExportDatabase.Click
        ExportDatabase()
    End Sub

    Private Sub btnImportDatabase_Click(sender As Object, e As EventArgs) Handles btnImportDatabase.Click
        ImportDatabase()
    End Sub

    Private Sub btnImportAsCopy_Click(sender As Object, e As EventArgs) Handles btnImportAsCopy.Click
        ImportDatabaseAsCopy()
    End Sub
End Class