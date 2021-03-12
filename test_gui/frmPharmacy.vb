Public Class frmPharmacy

    Dim currentContactPanel As String = Nothing

    Dim dsPhysicians As DataSet
    Dim dsPatients As DataSet
    Dim dsMedications As DataSet
    Dim intPatientID As New ArrayList
    Dim intMedID As New ArrayList
    Dim intPhysicianID As New ArrayList
    Dim intPatientIDfromArray As Integer = 0
    Dim intMedIDfromArray As Integer = 0
    Dim intPhysicianIDfromArray As Integer = 0

    Private Sub frmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPatientName.Items.Clear()
        cmbOrderedBy.Items.Clear()
        cmbMedication.Items.Clear()
        cmbStrength.Items.Clear()
        cmbFrequencyNumber.Items.Clear()
        txtQuantity.Text = 1
        PopulateFrequencyNumberComboBox()
        Dim intCounter As Integer = 0
        dsMedications = ExecuteSelectQuery("SELECT * From Medication Inner Join DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID WHERE DrawerMedication.Active_Flag = '1' ORDER BY Medication.Medication_ID")
        dsPhysicians = ExecuteSelectQuery("Select * From Physician WHERE Active_Flag = '1' ORDER BY Physician_Last_Name, Physician_First_Name;")
        dsPatients = ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = '1' ORDER BY Patient_Last_Name, Patient_First_Name;")

        For Each dr As DataRow In dsPatients.Tables(0).Rows
            cmbPatientName.Items.Add(dr(EnumList.Patient.LastName) & ", " & dr(EnumList.Patient.FristName) &
                                     "   MRN: " & dr(EnumList.Patient.MRN_Number))
            intPatientID.Add(dr(EnumList.Patient.ID))
        Next

        For Each dr As DataRow In dsPhysicians.Tables(0).Rows
            cmbOrderedBy.Items.Add(dr(EnumList.Physician.LastName) & ", " & dr(EnumList.Physician.FirstName))
            intPhysicianID.Add(dr(EnumList.Physician.Id))
        Next

        For Each dr As DataRow In dsMedications.Tables(0).Rows
            cmbMedication.Items.Add(dr(EnumList.Medication.Name))
            intMedID.Add(dr(EnumList.Medication.ID))
        Next
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/11/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/11/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnORder.Click
        If cmbPatientName.SelectedIndex = -1 Or cmbMedication.SelectedIndex = -1 Or cmbOrderedBy.SelectedIndex = -1 Then
            MessageBox.Show("Please select a patient, medication and physician before placing the order")
        Else
            Dim dtmOrderTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            PharmacyOrder.PharmacyOrder(intPatientIDfromArray, intMedIDfromArray, intPhysicianIDfromArray, txtQuantity.Text, txtType.Text, cmbFrequencyNumber.SelectedItem.ToString)
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/11/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/11/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub btnIncrement_Click(sender As Object, e As EventArgs) Handles btnIncrement.Click
        If Not IsNumeric(txtQuantity.Text) Then
            txtQuantity.Text = 0
        End If
        ButtonIncrement(1000, txtQuantity)

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/11/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/11/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub btnDecrement_Click(sender As Object, e As EventArgs) Handles btnDecrement.Click
        If Not IsNumeric(txtQuantity.Text) Then
            txtQuantity.Text = 2
        End If
        ButtonDecrement(txtQuantity)
    End Sub

    Private Sub cmbPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientName.SelectedIndexChanged
        intPatientIDfromArray = intPatientID(cmbPatientName.SelectedIndex)
        txtPatientDOB.Text = ExecuteScalarQuery("select Date_of_Birth from Patient where Patient_ID = '" & intPatientIDfromArray & "'")
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/11/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/11/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.KeyPress
        KeyPressCheck(e, "0123456789")
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/11/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/11/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub cmbMedication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedication.SelectedIndexChanged
        cmbStrength.Items.Clear()
        intMedIDfromArray = intMedID(cmbMedication.SelectedIndex)
        Dim dsMedication As DataSet = ExecuteSelectQuery("select * from Medication where Medication_ID = '" & intMedIDfromArray & "'")
        txtType.Text = dsMedication.Tables(0).Rows(0)(EnumList.Medication.Snyonym)
        cmbStrength.Items.Add(dsMedication.Tables(0).Rows(0)(EnumList.Medication.type))
        cmbStrength.SelectedIndex = 0
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/11/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/11/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub cmbOrderedBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrderedBy.SelectedIndexChanged
        intPhysicianIDfromArray = intPhysicianID(cmbOrderedBy.SelectedIndex)
    End Sub
End Class