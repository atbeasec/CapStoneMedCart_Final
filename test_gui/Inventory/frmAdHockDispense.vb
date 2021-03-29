Public Class frmAdHockDispense
    Dim intPatientID As New ArrayList
    Private Sub frmAdHockDispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set ad efault quantity to the quantity textbox
        Dim intDefaultQuantity As Integer = 1
        txtQuantity.Text = intDefaultQuantity

        cmbMedications.Items.Clear()
        AdHoc.GetAllMedicationsForListbox()
        AdHoc.PopulatePatientsAdhoc()
    End Sub

    Private Sub btnIncrementQuantity_Click(sender As Object, e As EventArgs) Handles btnIncrementQuantity.Click
        ButtonIncrement(1000, txtQuantity)
    End Sub

    Private Sub btnDecrementQuantity_Click(sender As Object, e As EventArgs) Handles btnDecrementQuantity.Click
        If Not txtQuantity.Text = 0 Then
            ButtonDecrement(txtQuantity)
        End If

    End Sub

    Private Sub cmbMedications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedications.SelectedIndexChanged
        AdHoc.SetMedicationProperties()
    End Sub

    Private Sub cmbPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientName.SelectedIndexChanged
        AdHoc.PopulatePatientInformation()
    End Sub

    Private Sub btnDispense_Click(sender As Object, e As EventArgs) Handles btnDispense.Click

        'make sure that both patient and medication is selected before ordering the AdHoc
        If IsNothing(cmbMedications.SelectedItem) And IsNothing(cmbPatientName.SelectedItem) Then
            MessageBox.Show("Please select a medication and patient")
        Else
            If cmbMedications.SelectedItem = lstboxAllergies.SelectedItem Then
                'show witness sign off
                frmWitnessSignOff.Label1.Text = cmbMedications.SelectedItem.ToString
                'if authentication from witness sign off form comes back then
                'If Not IsNothing(cmbMedications.SelectedItem) Then
                '    DispenseHistory.DispenseMedication(DispenseHistory.SplitMedicationString(cmbMedications.SelectedItem), intPatientID)
                'else
                'End If
                MessageBox.Show("Patient is allergic to this Medication")
            Else

                If Not IsNothing(cmbMedications.SelectedItem) And txtQuantity.Text > 0 Then
                    If Not IsNothing(cmbPatientName.SelectedItem) Then

                        AdHoc.InsertAdHoc(AdHoc.intPatientIDArray(cmbPatientName.SelectedIndex), "1", txtQuantity.Text, AdHoc.intMedIDArray(cmbMedications.SelectedIndex))
                        AdHoc.clearAdhocBoxes()
                        MessageBox.Show("Order Successfully placed")
                    Else
                        MessageBox.Show("Please select a patient")
                    End If
                Else
                    MessageBox.Show("Please select a medication")
                End If
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

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
        If IsNumeric(sender.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantity)
        End If

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.Validated
        If IsNumeric(sender.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantity)
        Else
            MessageBox.Show("Please make sure you enter a positive number 1-1000")
            sender.Text = "1"
        End If
        'LimitQuantityToQuantityStocked(SQLreturnValue, sender)

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
End Class