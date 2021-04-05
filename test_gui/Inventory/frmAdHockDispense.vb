Public Class frmAdHockDispense
    Dim intPatientID As New ArrayList
    Public blnSignedOff As Boolean = True
    Public blnOverride As Boolean = False
    Private Sub frmAdHockDispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set ad efault quantity to the quantity textbox

        cmbMedications.Items.Clear()
        AdHoc.GetAllMedicationsForListbox()
        AdHoc.PopulatePatientsAdhoc()
    End Sub

    Private Sub cmbMedications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedications.SelectedIndexChanged
        AdHoc.SetMedicationProperties()
    End Sub

    Private Sub cmbPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientName.SelectedIndexChanged
        AdHoc.PopulatePatientInformation()
    End Sub

    Private Sub btnDispense_Click(sender As Object, e As EventArgs) Handles btnDispense.Click
        'make sure that both patient and medication is selected before ordering the AdHoc
        If IsNothing(cmbMedications.SelectedItem) Then
            MessageBox.Show("Please select a medication")
        ElseIf IsNothing(cmbPatientName.SelectedItem) Then
            MessageBox.Show("Please select a patient")
        ElseIf txtAmount.Text = Nothing Or txtAmount.Text.Trim.Length = 0 Then
            MessageBox.Show("Please select a quantity")
        ElseIf txtUnit.Text = Nothing Or txtUnit.Text.Trim.Length = 0 Then
            MessageBox.Show("Please select a Unit for the amount")
        Else
            For Each allergy In lstboxAllergies.Items
                If cmbMedications.SelectedItem.ToString.ToLower.Contains(allergy.ToString.ToLower) Then
                    'show witness sign off
                    frmWitnessSignOff.Label1.Text = cmbMedications.SelectedItem.ToString
                    frmWitnessSignOff.referringForm = Me
                    'added formatting in case a drug interaction override was chosen first
                    frmWitnessSignOff.Label2.Text = "Causes Allergic Reaction to Patient"
                    frmWitnessSignOff.Text = "Allergies Override"
                    frmWitnessSignOff.Label1.Location = New Point(3, 34)
                    frmWitnessSignOff.Label2.Location = New Point(21, 64)
                    frmWitnessSignOff.Label5.Visible = False
                    frmWitnessSignOff.Label6.Visible = False
                    frmWitnessSignOff.ShowDialog()


                    'if authentication from witness sign off form comes back then
                    If blnOverride Then
                        Dim intMaxAllergyID
                        ' pull the information to insert
                        If ExecuteScalarQuery("Select AllergyOverride_ID from AllergyOverride") = Nothing Then
                            intMaxAllergyID = 0
                        Else
                            intMaxAllergyID = ExecuteScalarQuery("SELECT MAX(AllergyOverride_ID) from AllergyOverride")
                            intMaxAllergyID += 1
                        End If

                        ExecuteInsertQuery("INSERT INTO AllergyOverride(AllergyOverride_ID, Patient_TUID, User_TUID, Allergy_Name, DateTime) " &
                                               "Values(" & intMaxAllergyID & ", " & intPatientIDArray(Me.cmbPatientName.SelectedIndex) & ", " & LoggedInID & ", '" & allergy & "', '" & DateTime.Now & "')")
                    Else
                        MessageBox.Show("Dispense canceled by user.")
                        blnOverride = False
                        blnSignedOff = False
                        Exit Sub
                    End If

                Else
                    ' do nothing as there is no allergy
                    blnOverride = False
                End If
            Next

            'If the user didn't already sign off to dispense the medication,
            'check interactions
            DrugInteractionOverride(cmbMedications.SelectedItem, txtMRN.Text, "AdHoc")

            'If the user signs off for any override, dispense the medication
            If blnSignedOff = True Then
                blnSignedOff = False
                Dim intPatientID As Integer = AdHoc.intPatientIDArray(cmbPatientName.SelectedIndex)
                Dim intMedID As Integer = AdHoc.intMedIDArray(cmbMedications.SelectedIndex)
                Dim strAmount As String = txtAmount.Text
                Dim strUnit As String = txtUnit.Text
                Dim intMedDrawer As Integer = AdHoc.intDrawerMedArray(cmbMedications.SelectedIndex)
                'AdHoc.InsertAdHoc(AdHoc.intPatientIDArray(cmbPatientName.SelectedIndex), LoggedInID, CInt(txtQuantity.Text), AdHoc.intMedIDArray(cmbMedications.SelectedIndex), AdHoc.intDrawerMedArray(cmbMedications.SelectedIndex))
                'AdHoc.clearAdhocBoxes()
                'MessageBox.Show("Order Successfully placed")

                frmDispense.setintEntered(1)
                frmDispense.AdhocDispenseSetInformation(strAmount, strUnit, intMedDrawer)
                frmDispense.SetPatientID(intPatientID)
                frmDispense.SetintMedicationID(intMedID)
                frmMain.OpenChildForm(frmDispense)
                DispenseHistory.DispensemedicationPopulate(intPatientID, intMedID)
                PatientInformation.PopulatePatientDispenseInfo(intPatientID)
                PatientInformation.PopulatePatientAllergiesDispenseInfo(intPatientID)

            End If

        End If

    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: txtQuantity_KeyPress			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 2/17/2021                    		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:            								   */             
    '/*  This is going to handle what happens when a user make a key press */
    '/*  in the txtQuantity textbox. It will make sure that the key press is*/
    '/*  numeric.                                                          */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789.")

    End Sub

    Private Sub txtUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789.abcdefghijklmnopqrstuvwxyz /-")

    End Sub
    '/*********************************************************************/
    '/*                   Function NAME: txtDateOfBirth_TextChanged()     */         
    '/*********************************************************************/
    '/*              WRITTEN BY:  Collin Krygier          		          */   
    '/*		         DATE CREATED: 		 3/17/2021                        */                             
    '/*********************************************************************/
    '/*  SUB PURPOSE:	    							                  */             
    '/*	 This function simply takes a string and truncates it to a new    */
    '/*  length if the string is longer than the specified length. If not,*/
    '/*  it will be left alone and we return the original string passed in*/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/* None                                                              */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	sender As Object                                                  */ 
    '/*	e As EventArgs                                                    */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	None                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  3/17/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub txtDateOfBirth_TextChanged(sender As Object, e As EventArgs) Handles txtDateOfBirth.TextChanged

        Dim truncatedDate As String = Nothing

        If txtDateOfBirth.Text.Length > 10 Then

            truncatedDate = CStr(txtDateOfBirth.Text.Substring(0, 10))
        Else
            truncatedDate = CStr(txtDateOfBirth.Text)
        End If

        txtDateOfBirth.Text = truncatedDate
    End Sub

    Private Sub txtStrength_TextChanged(sender As Object, e As EventArgs) Handles txtStrength.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

    End Sub
End Class