Public Class frmDiscrepancies

    Dim currentContactPanelName As String = Nothing
    Dim ContactPanelsAddedCount As Integer = 0

    Private Sub frmDiscrepancies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim genName1 As String = "Benzhydrocodone "
        'Dim genName2 As String = "hydrocodone bitartrate"
        'Dim genName3 As String = "phenylephrine"
        'Dim genName4 As String = "Morphine"
        'Dim genName5 As String = "Codeine"

        'Dim quantity1 As String = "1"
        'Dim quantity2 As String = "1"
        'Dim quantity3 As String = "2"
        'Dim quantity4 As String = "1"
        'Dim quantity5 As String = "3"

        'Dim measure1 As String = "10 mg"
        'Dim measure2 As String = "10 mg"
        'Dim measure3 As String = "50 mg"
        'Dim measure4 As String = "10 mg"
        'Dim measure5 As String = "10 mg"

        'Dim dispensedBy1 As String = "3"
        'Dim dispensedBy2 As String = "5 "
        'Dim dispensedBy3 As String = "6"
        'Dim dispensedBy4 As String = "1"
        'Dim dispensedBy5 As String = "2"

        'Dim dispenseDate1 As String = "11/11/2020"
        'Dim dispenseDate2 As String = "11/5/2020"
        'Dim dispenseDate3 As String = "11/4/2020"
        'Dim dispenseDate4 As String = "11/1/2020"
        'Dim dispenseDate5 As String = "10/28/2020"

        'Dim dispenseTime1 As String = "8:05 AM"
        'Dim dispenseTime2 As String = "9:13 AM"
        'Dim dispenseTime3 As String = "8:34 AM"
        'Dim dispenseTime4 As String = "1:05 PM"
        'Dim dispenseTime5 As String = "5:04 AM"

        'Dim strID As Integer = 1
        'Dim strID2 As Integer = 2
        'Dim strID3 As Integer = 3
        'Dim strID4 As Integer = 4



        '************************************************************************************
        ' Notes for who writes the query. Use the Create panel to loop through your data set 
        ' to send the database table data to the UI. replace the mock data with your tabledata
        '************************************************************************************

        'CreatePanel(flpDiscrepancies, strID, genName1, quantity2, dispensedBy5, quantity1, dispenseDate1, dispenseTime1)
        'CreatePanel(flpDiscrepancies, strID2, genName1, quantity2, dispensedBy5, quantity1, dispenseDate1, dispenseTime1)
        'CreatePanel(flpDiscrepancies, strID3, genName1, quantity2, dispensedBy5, quantity1, dispenseDate1, dispenseTime1)
        'CreatePanel(flpDiscrepancies, strID3, genName1, quantity2, dispensedBy5, quantity1, dispenseDate1, dispenseTime1)
        Discrepancies.PopulateDiscrepancies()

    End Sub


    '/********************************************************************/
    '/*                   SUB NAME: CreatePanel            	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUB PURPOSE: contains the logic and mechanics to display db data*/
    '/*   to the front end in the form of panels.                        */
    '/********************************************************************/
    '/*  CALLED BY:                                      	      		 */				            
    '/*                                              			         */         
    '/********************************************************************/
    '/*  CALLS:							                            	 */		                  
    '/*            CreateIDLabel        					             */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/* flpPannel- A flow panel that contains subpanels which contain    */
    '/*    the rest of the controls.                                     */
    '/* strID- the ID of the discrepancy from the DB                     */
    '/* strMedication- the medication from the DB in question            */
    '/* strDrawerNumber- the drawer number of the medication in question */
    '/* strExpectedCount- the count the system is expecting to have      */
    '/* strActualCount- the count of medication that is physically present/
    '/* strDTE- date the discrepancy was discovered                      */
    '/* strTime- time the discrepancy was discovered                     */
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	CreatePanel(flpDiscrepancies, strID, genName1, quantity2, dispensedBy5, quantity1, dispenseDate1, dispenseTime1)				                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 pnl- an object of type panel that will be created at run time   */
    '/*	 pnlMain- an object of type panel that will be created at run time/
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strMedication As String, ByVal strDrawerNumber As String, ByVal strExpectedCount As String, ByVal strActualCount As String, ByVal strDateAndTime As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(flpDiscrepancies.Size.Width - 6, 47)
            .Name = "pnlIndividualDiscrepancyPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel
            .BackColor = Color.White
            .Size = New Size(flpDiscrepancies.Size.Width - 5, 45)
            .Name = "pnlIndividualDiscrepancy" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        AddHandler pnlMainPanel.Click, AddressOf SingleClickButtonShow
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        'add controls to this panel
        Const Y As Integer = 20
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label
        Dim lblID7 As New Label

        'anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID7, "lblDiscrepancyID", lblDiscrepancyID.Location.X, Y, strID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID, "lblMedication", lblMedication.Location.X, Y, strMedication, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDrawer", lblDrawer.Location.X, Y, strDrawerNumber, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblExpectedCount", lblExpectedCount.Location.X, Y, strExpectedCount, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblActualCount", lblActualCount.Location.X, Y, strActualCount, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDateAndTime", lblDateTime.Location.X, Y, strDateAndTime, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click

        Dim paddingPanel As Control
        Dim controlPanel As Control
        Dim checkIfSelected As Boolean = False

        For Each paddingPanel In flpDiscrepancies.Controls
            Debug.Print(paddingPanel.Name)
            For Each controlPanel In paddingPanel.Controls
                If controlPanel.Name.Contains("pnlIndividualDiscrepancy") Then
                    If controlPanel.BackColor = Color.FromArgb(71, 103, 216) Then
                        checkIfSelected = True
                    End If
                End If
            Next
        Next

        If checkIfSelected = False Then
            MessageBox.Show("Please Select a discrepancy to resolve")
        Else
            frmResolve.Show()
        End If


    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: getSelectedDiscrepancy	         */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  FUNCTION PURPOSE: this function retrieves the ID of the discrepancy
    '/*   by taking it off of the panel on the user interface.		     */	                       
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: frmResolve                             	      		 */				            
    '/*                                        			            	 */         
    '/********************************************************************/
    '/*  CALLS:							                            	 */		                  
    '/*             (NONE)					                        	 */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 (NONE)                                                          */								                        
    '/*                                                                  */  
    '/********************************************************************/
    '/*  RETURNS:							                             */	                          
    '/*  intDiscrepancyID- an integer that is the discrepancy            */								             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	getSelectedDiscrepancy()					                     */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 ctlPaddingPanel- a control object that is used to hold all of the/
    '/*  controls that will be iterated over.					         */
    '/*	 ctlPanel- a control object that is used to hold all of the      */
    '/*  controls that will be iterated over.					         */
    '/*	 lbl- a control object that is used to hold all of the           */
    '/*  controls that will be iterated over.					         */
    '/*  intDiscrepancyID- integer representing the ID of the discrepancy*/
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Function getSelectedDiscrepancyLabel() As Label

        Dim ctlPaddingPanel As Control
        Dim ctlPanel As Control
        Dim lbl As Control
        ' Dim intDiscrepancyID As Integer
        Dim lblID As Label = Nothing

        For Each ctlPaddingPanel In flpDiscrepancies.Controls
            'Debug.Print(paddingPanel.Name)
            For Each ctlPanel In ctlPaddingPanel.Controls
                If ctlPanel.Name.Contains("pnlIndividualDiscrepancy") Then
                    If ctlPanel.BackColor = Color.FromArgb(71, 103, 216) Then
                        For Each lbl In ctlPanel.Controls
                            If lbl.Name.Contains("lblDiscrepancyID") Then

                                ' grab the control and cast it as a label
                                ' intDiscrepancyID = CInt(lbl.Text)
                                lblID = CType(lbl, Label)
                            End If
                        Next
                    End If
                End If
            Next
        Next

        Return lblID
        'Return intDiscrepancyID

    End Function

    '/********************************************************************/
    '/*                   SUB NAME: SingleClickButtonShow   	         */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUB PURPOSE: contains functionality that is assigned to the panel/
    '/*  It ensures that only a single panel can be selected at one time */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY:                                      	      		 */				            
    '/*            (NONE)                           			         */         
    '/********************************************************************/
    '/*  CALLS:							                            	 */		                  
    '/*             (ResetColorsOnPanel)					             */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 sender- object representing the selected control                */								                        
    '/*  e- the base class containing the data                           */  
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	getSelectedDiscrepancy					                         */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 pnlSelected- an object of type panel that will be iterated over */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub SingleClickButtonShow(sender As Object, e As EventArgs)

        Dim pnlSelected As Panel
        pnlSelected = CType(sender, Panel)
        Debug.Print(CheckIfPanelIsSelected(pnlSelected))

        If CheckIfPanelIsSelected(pnlSelected) = True Then

            Dim paddingPanel As Control
            Dim controlPanel As Control

            For Each paddingPanel In flpDiscrepancies.Controls
                Debug.Print(paddingPanel.Name)
                For Each controlPanel In paddingPanel.Controls
                    If controlPanel.Name.Contains("pnlIndividualDiscrepancy") Then
                        If controlPanel.BackColor = Color.FromArgb(71, 103, 216) Then
                            controlPanel.BackColor = Color.White
                            For Each lbl In controlPanel.Controls
                                lbl.ForeColor = Color.Black
                            Next
                        End If
                    End If
                Next
            Next
            ResetColorsOnPanel(pnlSelected)
        Else
            ResetColorsOnPanel(pnlSelected)
        End If

    End Sub

    '/********************************************************************/
    '/*                   SUBROUTINE NAME: ResetColorsOnPanel   	     */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE: takes the color of the panel and decides	 */	                       
    '/*  if it needs to change the back color or text color              */
    '/********************************************************************/
    '/*  CALLED BY: SingleClickButtonShow                         		 */				            
    '/*                                        			            	 */         
    '/********************************************************************/
    '/*  CALLS:							                            	 */		                  
    '/*             (NONE)					                        	 */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 (NONE)                                                          */								                        
    '/*                                                                  */  
    '/********************************************************************/
    '/*  RETURNS:							                             */	                          
    '/*  intDiscrepancyID- an integer that is the discrepancy            */								             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	ResetColorsOnPanel(pnlName)					                     */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*                                                                  */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub ResetColorsOnPanel(pnlSelected As Panel)

        If Not pnlSelected.BackColor = Color.FromArgb(71, 103, 216) Then
            pnlSelected.BackColor = Color.FromArgb(71, 103, 216)

            For Each lbl In pnlSelected.Controls
                lbl.ForeColor = Color.White
            Next
        Else
            pnlSelected.BackColor = Color.Gainsboro

            For Each lbl In pnlSelected.Controls
                lbl.ForeColor = Color.Black
            Next
        End If

    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: CheckIfPanelIsSelected	         */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  FUNCTION PURPOSE: this function checks to see if any panels are */	 
    '/*  are currently selected (highlighted blue).                      */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: SingleClickButtonShow                          		 */				            
    '/*                                        			            	 */         
    '/********************************************************************/
    '/*  CALLS:							                            	 */		                  
    '/*             (NONE)					                        	 */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 pnl- a control object of type Panel                             */								                        
    '/*                                                                  */  
    '/********************************************************************/
    '/*  RETURNS:							                             */	                          
    '/*  blnIsSelected- a boolean                                        */								             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	getSelectedDiscrepancy()					                     */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 paddingPanel- a control object that is used to hold all of the   /
    '/*  controls that will be iterated over.					         */
    '/*	 controlPanel- a control object that is used to hold all of the  */
    '/*  controls that will be iterated over.					         */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Private Function CheckIfPanelIsSelected(pnl As Panel) As Boolean

        Dim blnIsSelected As Boolean = False
        Dim paddingPanel As Control
        Dim controlPanel As Control

        For Each paddingPanel In flpDiscrepancies.Controls
            Debug.Print(paddingPanel.Name)

            For Each controlPanel In paddingPanel.Controls
                If controlPanel.Name.Contains("pnlIndividualDiscrepancy") Then

                    If controlPanel.BackColor = Color.FromArgb(71, 103, 216) Then
                        blnIsSelected = True
                    End If

                End If
            Next
        Next

        Return blnIsSelected

    End Function

End Class