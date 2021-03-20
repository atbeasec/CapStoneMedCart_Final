Public Class frmWaste

    Private intPatientInformationMRN As Integer
    Public intMedicationID As New ArrayList
    Private intDrawerID As New ArrayList
    Private intDrawerMedTUID As Integer

    'this function should set Patient MRN using PatientID
    Public Sub SetPatientMRN(ByVal mrn As Integer)

        intPatientInformationMRN = mrn

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOther.CheckedChanged

        MovePanelOnScreen()

    End Sub

    Private Sub Waste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Visible = False

        ' if the patient mrn is nothing it means the waste form is being accessed
        ' from the ad hoc menu, otherwise it would be pased a value.
        If intPatientInformationMRN = Nothing Then
            btnBack.Visible = False
        End If

        Inventory.PopulateWasteComboBoxMedication()
        Dim dsWitness As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from User WHERE Active_Flag = '1'")
        For Each dr As DataRow In dsWitness.Tables(0).Rows()
            cboWitness.Items.Add(dr(EnumList.User.UserName))
        Next
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: MovePanelOnScreen	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This sub makes the form dynamic by moving the*/					                       
    '/*  witness sign off down when the radio button is selected         */
    '/********************************************************************/
    '/*  CALLED BY: checkchanged events                    	      		 */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	            (NONE)	                                             */								                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	MovePanelOnScreen()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 ctl- a control object that is used to hold all of the controls  */
    '/*  that will be iterated over.					                 */
    '/*  rbtn- a radio button control that the control will be casted to */
    '/*  for the purpose of accessing the radio button methods.          */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub MovePanelOnScreen()

        Dim ctl As Control
        Dim rbtn As RadioButton = Nothing

        For Each ctl In pnlRadioButtons.Controls
            If TypeName(ctl) = "RadioButton" Then
                If ctl.Name = "rbtnOther" Then
                    rbtn = CType(ctl, RadioButton)
                    If rbtn.Checked = True Then
                        pnlSignOff.Dock = DockStyle.Bottom
                    Else
                        pnlSignOff.Dock = False
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click

        Dim intWasteAmount As Integer
        ErrorProvider1.Clear()

        If Not IsNumeric(txtQuantity.Text) Then
            ErrorProvider1.SetError(pnlQuantity, "Please enter a numeric value")
        Else

            If radAllMed.Checked = True Then
                intWasteAmount = CreateDatabase.ExecuteScalarQuery("SELECT Quantity from DrawerMedication where DrawerMedication_ID = '" & intDrawerMedTUID & "'")
            Else
                intWasteAmount = txtQuantity.Text
            End If

            If Not cboWitness.SelectedIndex = -1 And Not cboMedication.SelectedIndex = -1 And Not cboDrawers.SelectedIndex = -1 Then
                Dim intMedID As Integer = intMedicationID(cboMedication.SelectedIndex)
                Inventory.WasteMedication(intDrawerMedTUID, intWasteAmount, intMedID)
                cboMedication.SelectedIndex = -1
                RadioButton2.Checked = True
                cboWitness.SelectedIndex = -1
            Else
                MessageBox.Show("Please select a Medication, Drawer, and User for the sign off")
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPatientInfo.setPatientMrn(intPatientInformationMRN)
        frmMain.OpenChildForm(frmPatientInfo)
    End Sub

    Private Sub cboMedication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMedication.SelectedIndexChanged
        cboDrawers.Items.Clear()
        intDrawerID.Clear()

        If Not cboMedication.SelectedIndex = -1 Then
            Dim intMedID As Integer = intMedicationID(cboMedication.SelectedIndex)
            Dim dsDrawerBin As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT * FROM DrawerMedication where Medication_TUID = '" & intMedID & "' AND Active_Flag = 1")
            For Each dr As DataRow In dsDrawerBin.Tables(0).Rows
                cboDrawers.Items.Add("Drawer Number: " & dr(1) & " Bin Number: " & dr(4))
                intDrawerID.Add(dr(0))
            Next
        End If
    End Sub

    Private Sub radWasteSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles radWasteSpecific.CheckedChanged, radAllMed.CheckedChanged
        If radWasteSpecific.Checked = True Then
            pnlQuantity.Visible = True
        Else
            pnlQuantity.Visible = False
        End If
    End Sub

    Private Sub cboDrawers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrawers.SelectedIndexChanged
        If Not cboDrawers.SelectedIndex = -1 Then
            intDrawerMedTUID = intDrawerID(cboDrawers.SelectedIndex)
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
        If txtQuantity.Text IsNot "" Then
            GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
        End If
    End Sub

    Private Sub btnIncrementQuantity_Click(sender As Object, e As EventArgs) Handles btnIncrementQuantity.Click
        If Not IsNumeric(txtQuantity.Text) Then
            txtQuantity.Text = 0
        End If
        ButtonIncrement(1000, txtQuantity)
    End Sub

    Private Sub btnDecrementQuantity_Click(sender As Object, e As EventArgs) Handles btnDecrementQuantity.Click
        If Not IsNumeric(txtQuantity.Text) Then
            txtQuantity.Text = 2
        End If
        ButtonDecrement(txtQuantity)
    End Sub
End Class