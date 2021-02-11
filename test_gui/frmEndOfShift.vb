Public Class frmEndOfShift

    '/*******************************************************************/
    '/*                   FILE NAME:  frmEndOfShift.vb                  */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier  		            */
    '/*		         DATE CREATED: 2/5/2020         		            */
    '/*******************************************************************/
    '/*  Class PURPOSE:								                    */
    '/*											                        */
    '/*  Contains all of the functionality that occurs on this form     */
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
    '/* the program will invoke this class when a user selects the      */
    '/* end of shift button in the sub menu.                            */
    '/*******************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                */
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
    '/*  Collin Krygier  2/5/2021    Initial creation                   */
    '/*******************************************************************/

    Dim ContactPanelsAddedCount As Integer = 0
    Dim CurrentContactPanelName As String = Nothing

    Private Sub frmEndOfShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: CreatePanel()                  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/5/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is routine is dynamically creates panels that are placed    */ 
    '/*	 inside of the flowpanel that is fixed on the form. The panels are*/
    '/*	 created here, assigned handlers, and the contents of the panels  */
    '/*	 are updated in this routine                                      */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*   btnAllMedications, btnNonControlled, btnControlled              */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 NONE                                                             */ 
    '/* flpPannel- the flow panel which the user wants to create the      */
    '/*     create the single panel.                                      */
    '/* intMedicationTUID- value from the database we will store in the   */
    '/*     control during runtime to save on a backend query later when  */
    '/*     extracting data to send to the database.                      */
    '/* strMedicationName- name of the medication that is assigned to     */
    '/*     to some drawer and section in the cart.                       */
    '/* strDrawerNumber- the drawer number which the medication being     */
    '/*     sent to this method is stored in.                             */
    '/* strSection- the section which the medication being sent here is   */
    '/*     stored in.                                                    */
    '/* strSystemCount- the quantity of the drug that the system assumes  */
    '/*     should be in the drawer.                                      */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 CreatePanel(flpEndOfShiftCount, medTUID1, genName1, intNum1, intNum3, intNum5)   
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	pnl- is the pnl which we are creating for padding purposes        */
    '/* pnlMainPanel- is the pnl which we are going to add controls       */
    '/* lblID1 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID2 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID3 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID4 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Collin Krygier  2/5/2021    Initial creation                     */
    '/*********************************************************************/
    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal intMedicationTUID As Integer, ByVal strMedicationName As String, ByVal strDrawerNumber As String, ByVal strSection As String, ByVal strSystemCount As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(flpEndOfShiftCount.Size.Width - 5, 47)
            .Name = "pnlMedicationFlaggedPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(flpEndOfShiftCount.Size.Width - 5, 45)
            .Name = "pnlMedicationFlagged" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
            .Tag = intMedicationTUID
        End With

        'put the border panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        'AddHandler pnlMainPanel.Click, AddressOf DynamicSingleClickOpenPatient
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        CreateFlagBtn(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X + 8, 5)
        CreateTextBox(pnlMainPanel, getPanelCount(flpPannel), lblCount.Location.X, 6)

        Dim lblID1 As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID1, "lblMedication", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDrawerNumber", lblDrawerNum.Location.X, 20, strDrawerNumber, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblSection", lblSection.Location.X, 20, strSection, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblSystemCount", lblSystemCount.Location.X, 20, strSystemCount, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: ExtractFormDataForDatabase     */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/5/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to iterate over the flow panel to strip the data   */
    '/*  the user typed in when creating the report. This data will be    */
    '/*  passed to a method that updates the database discrepancies.      */ 
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 NONE                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	ExtractFormDataForDatabase()        							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	ctlPanelPadding- a control representing all of the panels that had*/
    '/*    were used to pad another panel.                                */
    '/* pnlPanel- a control which will contain only panels.               */
    '/* ctlControls- a control which represents all of the controls on a  */
    '/*     particular panel.                                             */
    '/* txtBox- represents a textbox, specifically the one that the user  */
    '/*    typed in to update the medication count in the drawer          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/5/2021    Initial creation                     */
    '/*********************************************************************/
    Sub ExtractFormDataForDatabase()

        Dim ctlPanelPadding As Control
        Dim pnlPanel As Control
        Dim ctlControl As Control
        Dim txtBox As TextBox

        'the construction of the panels is important to consider here. Look over the createPanel method to understand
        'there is a panel docked inside of another panel which is used to create a padding effect.
        'to get any controls off of the panel, we need to iterate twice through the controls to reach these items

        For Each ctlPanelPadding In flpEndOfShiftCount.Controls
            ' retreiving the pannels for padding

            For Each pnlPanel In ctlPanelPadding.Controls
                ' retreiving list of all panels within the padding

                For Each ctlControl In pnlPanel.Controls
                    ' retreiving the items in the panel such as labels and textbox values

                    If TypeName(ctlControl) = "TextBox" Then
                        txtBox = CType(ctlControl, TextBox)




                        'HERE call the insert or update statement to database to pipe the data over for reporting
                        Debug.Print(pnlPanel.Tag) 'tag will retreive the ID of the medication because it is added there inthe create panel method
                        Debug.Print(txtBox.Text) 'textbox will contain the typed count 
                        Debug.Print(pnlPanel.BackColor.ToString) 'if the backcolor is red, then the item was flagged
                        'Debug.Print(ctlControl.Name)






                    End If

                Next
            Next
        Next

    End Sub

    Private Sub btnControlled_Click(sender As Object, e As EventArgs) Handles btnControlled.Click
        flpEndOfShiftCount.Controls.Clear()
        ExtractFormDataForDatabase()
        ControlledMedsEndofShift()
    End Sub

    Private Sub btnNonControlled_Click(sender As Object, e As EventArgs) Handles btnNonControlled.Click
        flpEndOfShiftCount.Controls.Clear()
        NonControlledMedsEndofShift()
    End Sub

    Private Sub btnAllMedications_Click(sender As Object, e As EventArgs) Handles btnAllMedications.Click
        flpEndOfShiftCount.Controls.Clear()
        EndofShiftAllMedications()
    End Sub
End Class