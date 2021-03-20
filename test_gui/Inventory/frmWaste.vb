Public Class frmWaste

    Private intPatientInformationMRN As Integer
    Public intMedicationID As New ArrayList

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
        If Not cboWitness.SelectedIndex = -1 Then
            Inventory.WasteMedication()
            cboMedication.SelectedIndex = -1
            RadioButton2.Checked = True
            cboWitness.SelectedIndex = -1
        Else
            MessageBox.Show("Please select a user for the sign off")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPatientInfo.setPatientMrn(intPatientInformationMRN)
        frmMain.OpenChildForm(frmPatientInfo)
    End Sub

    Private Sub cboMedication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMedication.SelectedIndexChanged
        cboDrawers.Items.Clear()
        If Not cboMedication.SelectedIndex = -1 Then
            Dim intMedID As Integer = intMedicationID(cboMedication.SelectedIndex)
            Dim dsDrawerBin As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT * FROM DrawerMedication where Medication_TUID = '" & intMedID & "' AND Active_Flag = 1")
            For Each dr As DataRow In dsDrawerBin.Tables(0).Rows
                cboDrawers.Items.Add("Drawer Number: " & dr(1) & " Bin Number: " & dr(4))
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
End Class