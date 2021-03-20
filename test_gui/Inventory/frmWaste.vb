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

    '/********************************************************************/
    '/*                   FUNCTION NAME: Waste_Load	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This sub is the form loading event
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
    '/* dsWitness -- dataset that holds all users usernames for combobox
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
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

    '/********************************************************************/
    '/*                   FUNCTION NAME: btnWaste_Click	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	2/10/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This handles the beginning of the wasting logic
    '/*         it has the validation checks to make sure all the data is selected
    '/*         and valid. it will then pass along to the waste sub
    '/*
    '/*
    '/********************************************************************/
    '/*  CALLED BY: btnwaste.click                    	      		 */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*  		Inventory.WasteMedication				                         */	
    '/*  		Inventory.PopulateWasteComboBoxMedication()				                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	btnWaste_Click()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 intWasteAmount
    '/*  intMedID
    '/*
    '/*
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        2/10/21		    initial creation                 */
    '/********************************************************************/ 
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

                Inventory.PopulateWasteComboBoxMedication()
            Else
                MessageBox.Show("Please select a Medication, Drawer, and User for the sign off")
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPatientInfo.setPatientMrn(intPatientInformationMRN)
        frmMain.OpenChildForm(frmPatientInfo)
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: btnWaste_Click	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This sub is used to populate the drawers comboBox
    '/*  to list all the drawers the drug that was selected is in
    '/********************************************************************/
    '/*  CALLED BY: cboMedication.SelectedIndexChanged                   	      		 */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:	CreateDatabase.ExecuteSelectQuery(							                             */		                  			                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	cboMedication_SelectedIndexChanged()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 dsDrawerBin
    '/*  intMedID
    '/*
    '/*
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
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

    '/********************************************************************/
    '/*                   FUNCTION NAME: cboDrawers_SelectedIndexChanged	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This method is called when the radio buttons change
    '/* it is used to hide or unhide the quantity selector
    '/********************************************************************/
    '/*  CALLED BY:                     				             
    '/*    radWasteSpecific.CheckedChanged, radAllMed.CheckedChanged   
    '/********************************************************************/
    '/*  CALLS:								                             */		                  	               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	radWasteSpecific_CheckedChanged()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub radWasteSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles radWasteSpecific.CheckedChanged, radAllMed.CheckedChanged
        If radWasteSpecific.Checked = True Then
            pnlQuantity.Visible = True
        Else
            pnlQuantity.Visible = False
        End If
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: cboDrawers_SelectedIndexChanged     
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		            
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This method is used to update the drawerID array
    '/********************************************************************/
    '/*  CALLED BY:                     				             
    '/*     cboDrawers.SelectedIndexChanged    
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*  					                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	cboDrawers_SelectedIndexChanged()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub cboDrawers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrawers.SelectedIndexChanged
        If Not cboDrawers.SelectedIndex = -1 Then
            intDrawerMedTUID = intDrawerID(cboDrawers.SelectedIndex)
        End If
    End Sub
    '/********************************************************************/
    '/*                   FUNCTION NAME: txtQuantity_KeyPress	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This handles the keypress event for the txtquantity textbox
    '/********************************************************************/
    '/*  CALLED BY: txtQuantity.KeyPress                                     				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */
    '/* GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	txtQuantity_KeyPress(sender, e)				         				                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
        If txtQuantity.Text IsNot "" Then
            GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
        End If
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: txtQuantity_Validated	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This handles the validation event for the txtquantity textbox
    '/********************************************************************/
    '/*  CALLED BY: txtQuantity.Validated                                     				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */
    '/* GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	txtQuantity_Validated(sender, e)				         				                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub txtQuantity_Validated(sender As Object, e As EventArgs) Handles txtQuantity.Validated
        If txtQuantity.Text IsNot "" Then
            GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
        End If
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: btnWaste_Click	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This when the increment button is clicked
    '/********************************************************************/
    '/*  CALLED BY:                    	      		 */				            
    '/*  btnIncrementQuantity.Click                                      				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */
    '/* ButtonIncrement(txtQuantity)
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	btnIncrementQuantity_Click()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub btnIncrementQuantity_Click(sender As Object, e As EventArgs) Handles btnIncrementQuantity.Click
        If Not IsNumeric(txtQuantity.Text) Then
            txtQuantity.Text = 0
        End If
        ButtonIncrement(1000, txtQuantity)
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: btnWaste_Click	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	3/20/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This when the decrement button is clicked
    '/********************************************************************/
    '/*  CALLED BY:                    	      		 */				            
    '/*  btnDecrementQuantity.Click                                      				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */
    '/* ButtonDecrement(txtQuantity)
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	btnDecrementQuantity_Click()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        3/20/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub btnDecrementQuantity_Click(sender As Object, e As EventArgs) Handles btnDecrementQuantity.Click
        If Not IsNumeric(txtQuantity.Text) Then
            txtQuantity.Text = 2
        End If
        ButtonDecrement(txtQuantity)
    End Sub
End Class