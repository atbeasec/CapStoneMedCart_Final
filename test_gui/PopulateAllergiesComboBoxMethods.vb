Imports System.Text

Module PopulateAllergiesComboBoxMethods
    '/*********************************************************************/
    '/*                   FILE NAME: PopulatePatientComboBoxMethods          */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: Test_Gui		        		   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		             */		  
    '/*		         DATE CREATED:	2/8/2021                    		   */						  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									                   */			  
    '/*	 This contains the method to populate the patient Combo boxes on a */
    '/*  number of forms.                                                  */
    '/*********************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			   */ 
    '/*                                                    (NONE)	   */	  
    '/*********************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							   */			  
    '/*                          (NOTHING)					   */		  
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */			  
    '/*											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			         */		  
    '/*						  	 (NONE)			   */					  
    '/*********************************************************************/
    '/* COMPILATION NOTES(will include version notes including libraries):*/
    '/* 											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */				  
    '/*											   */					  
    '/*  WHO   WHEN     WHAT								   */			  
    '/*  ---   ----     ------------------------------------------------- */
    '/*********************************************************************/





    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: populatePatientNameComboBo      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                */   
    '/*		         DATE CREATED: 	2/7/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								                 */             
    '/*	 This is going to populate a combo box with a patients first and last*/                     
    '/*  name.                                                             */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 cboPatient - this is the combo box we are going to be populating */
    '/*  dsPatients - this is the data set of the patients we have in the */
    '/*     database.                                                     */
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*	miscMethods.populatePatientNameComboBox(cboPatientName,dsPatients) */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 strbTesting - this is a string builder that is used to make the  */                     
    '/*     make the string that will be added to the combo box. It will be*/
    '/*     The first and laste name.                                      */
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/


    Sub populateAllergiesComboBox(cmbAllergies As ComboBox, dsAllergies As DataSet)
        Dim strbTesting As New StringBuilder
        Dim dcAllergies As New AutoCompleteStringCollection
        cmbAllergies.Items.Clear()


        For Each row As DataRow In dsAllergies.Tables(0).Rows
            dcAllergies.Add(row(0).ToString())
        Next
        With cmbAllergies
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = dcAllergies
            .DataSource = dcAllergies
        End With
    End Sub
    Sub populateMedicationComboBox(cmbMedication As ComboBox, dsAllergies As DataSet)
        Dim strbTesting As New StringBuilder
        Dim dcAllergies As New AutoCompleteStringCollection
        cmbMedication.Items.Clear()


        For Each row As DataRow In dsAllergies.Tables(0).Rows
            dcAllergies.Add(row(0).ToString())
        Next
        With cmbMedication
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = dcAllergies
            .DataSource = dcAllergies
        End With
    End Sub
    Sub populateAllergyTypeComboBox(cmbAllergyType As ComboBox, dsAllergyType As DataSet)
        Dim strbTesting As New StringBuilder
        Dim dcAllergies As New AutoCompleteStringCollection
        cmbAllergyType.Items.Clear()


        For Each row As DataRow In dsAllergyType.Tables(0).Rows
            'If cmbAllergyType.FindStringExact(row(2).ToString()) = 0 Or dcAllergies.Count = 0 Then

            dcAllergies.Add(row(0).ToString())

            'End If
        Next
        With cmbAllergyType
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = dcAllergies
            .DataSource = dcAllergies
        End With
    End Sub
End Module
