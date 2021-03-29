Imports RestSharp
Imports Newtonsoft.Json.Linq
Imports System.Text

Module Interactions
    '/***************************************************************************/
    '/*                   FILE NAME: Interactions.vb                            */
    '/***************************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				                */
    '/***************************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		                */
    '/*		         DATE CREATED: January 25, 2021			                    */
    '/***************************************************************************/
    '/*  MODULE PURPOSE:								                        */
    '/*	The purpose of this is to handle all drug interactions in the           */
    '/* program. It will handle parsing the interactions from the               */
    '/* Rxnorm API and storing them into the database. It will also handle      */
    '/* alerting the user of an interactions between drugs that are             */
    '/* being dispensed and others the patient is prescribed.                   */
    '/*                                                                         */
    '/***************************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			            */
    '/*                         (NONE)	                                        */
    '/***************************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                        */
    '/*                        (NOTHING)					                    */
    '/***************************************************************************/
    '/* SAMPLE INVOCATION:								                        */
    '/*											                                */
    '/* the program will invoke this module when the program is pulling         */
    '/* new and/or updating drug information from the RXnorm API. this module   */
    '/* will then use the API information to update and insert new              */
    '/* drug interactions into the database. The program will also invoke       */ 
    '/* this module when a user clicks to dispense a medication. When the       */ 
    '/* dispense option is clicked this module will be invoked to check the     */
    '/* database for any drug interactions between the dispensed drug and       */
    '/* any other medications that the patient is prescribed and push           */
    '/* and alert to the screen for any found interactions                      */
    '/***************************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                        */
    '/*						  	 (NONE)			                                */
    '/***************************************************************************/
    '/* COMPILATION NOTES:								                        */
    '/* 											                            */
    '/* This project compiles normally under Microsoft Visual Basic.            */
    '/* All one needs to do Is open up the Solver project And compile.          */
    '/* No special compile options Or optimizations were used.  No              */
    '/* unresolved warnings Or errors exist under these compilation             */
    '/* conditions.									                            */
    '/******************************************************************        */
    '/* MODIFICATION HISTORY:						                            */
    '/*											                                */
    '/*  WHO                     WHEN        WHAT						        */
    '/*  Alexander Beasecker    1/25/2021   Initial creation                    */
    '*/  Dillen Perron          2/3/2021    Added Interaction function          */
    '/***************************************************************************/



    '/*********************************************************************/
    '/*                   FUNCTION NAME:  getDrugInteraction              */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: 2/3/2021         		              */
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */
    '/*											                          */
    '/* This function Is responsible for taking an rxui number and        */
    '/* check durg interactions                                           */
    '/*											                          */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*                                     				              */
    '/*********************************************************************/
    '/*  CALLS:										                      */
    '/*             (NONE)								                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/* 			                                                      */
    '/* 			                                                      */
    '/*********************************************************************/
    '/*  RETURNS:								                          */
    '/*       								                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */
    '/*											                          */
    '/*    getDrugInteraction("153010", "2760")					          */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):			    	          */
    '/*											                          */
    '/*	 url - holds a link to the api with the selected rxui             */
    '/*  restClient -			                                          */
    '/*  restRequest - 			                                          */
    '/*  result - holds the result of the api call (json format)          */
    '/*											                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO      WHEN     WHAT								              */
    '/*                                                                   */
    '/*  Dillen  02/3/21  Function that check Interations                 */
    '/*  Dillen  02/9/21  Added way to choose json Property to pull       */
    '/*                   from Interaction API                            */
    '/*********************************************************************/
    '/*  NP      02/9/2021 Added a return that returns the result to      */
    '/*                    remove the function has no return warning.     */
    '/********************************************************************/

    Function getDrugInteraction(rxcuiNum1 As String, rxcuiNum2 As String) As String

        'URL for finding interactions 
        Dim url As String = $"https://rxnav.nlm.nih.gov/REST/interaction/list.json?rxcuis={rxcuiNum1}+{rxcuiNum2}"
        'location in json of properties
        Dim trawlPointer As String = "$.interactionTypeGroup.interactionType.interactionPair"
        'inputJSON
        Dim inputJSON As JToken = rxNorm.GetJSON(url)
        'set Jtoken into array to pull data from json
        Dim trawledResult As JToken = inputJSON.SelectToken(trawlPointer)

        Return trawledResult
    End Function


    '/*********************************************************************/
    '/*                   FUNCTION NAME:   getInteractionsByName          */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: 2/18/2021         		              */
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */
    '/*											                          */
    '/* This function Is responsible for taking an rxui number and        */
    '/* check durg interactions                                           */
    '/*											                          */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*                                     				              */
    '/*********************************************************************/
    '/*  CALLS:										                      */
    '/*             (NONE)								                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/* 			                                                      */
    '/* 			                                                      */
    '/*********************************************************************/
    '/*  RETURNS:								                          */
    '/*       								                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */
    '/*											                          */
    '/* getInteractionsByName("153008", myPropertyNameList)	              */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):			    	          */
    '/*											                          */
    '/*	 url - holds a link to the api with the selected rxui             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO      WHEN     WHAT								              */
    '/*                                                                   */
    '/*  Dillen  02/18/21  Function that check Interations                */
    '/*  Dillen  02/25/21  Added functionality to return                  */
    '/*********************************************************************/
    Function getInteractionsByName(rxcuiNum As String, propertyNames As List(Of String)) As List(Of (PropertyName As String, PropertyValue As String))
        frmInventory.txtStatus.Text = "Checking network connectivity"
        ' Insert functionality to check the network connectivity
        Dim strSite As String ' insert functionality to return the site string

        frmInventory.txtStatus.Text = "Retrieving interactions via web API."
        'URL for finding interactions 
        Dim url As String = $"https://rxnav.nlm.nih.gov/REST/interaction/interaction.json?rxcui={rxcuiNum}"
        'location in json of properties
        Dim trawlPointer As String = "$.interactionTypeGroup[0].interactionType[0].interactionPair"
        'inputJSON
        Dim inputJSON As JToken = rxNorm.GetJSON(url)
        'set Jtoken into array to pull data from json
        Dim JsonJArray As JArray = inputJSON.SelectToken(trawlPointer)
        Dim JsonJArrayRxcui As JArray = New JArray
        'Stores our List of properties selected 
        Dim myReturnList As New List(Of (PropertyName As String, PropertyValue As String))
        Dim strName As String
        Dim strValue As String

        Dim intCounter As Integer = 0
        'Pulls out the data at our specified trawlPointer to retrieve severity, description, and rxcui
        For Each propertyName As String In propertyNames
            For Each item As JObject In JsonJArray
                For Each subItem As JProperty In item.Children
                    'this should return the property names severity and description
                    For Each propertyIdentifier In propertyNames
                        If subItem.Name.ToString.ToUpper = propertyIdentifier.ToUpper Then
                            strName = subItem.Name
                            strValue = subItem.Value
                            myReturnList.Add((strName, strValue))
                        End If
                    Next
                Next
                'parses json for rxcui this will return both what drug is searched and what drug it interacts with
                JsonJArrayRxcui = item("interactionConcept")
                For Each interactionConcept In JsonJArrayRxcui
                    For Each minConceptItem In interactionConcept
                        For Each values In minConceptItem
                            If values("rxcui") IsNot Nothing Then
                                If values("rxcui").ToString <> rxcuiNum Then
                                    strName = "rxcui" ' subItem.First.Value.Last.First.First.First.Name
                                    strValue = values("rxcui") 'subItem.First.Value.Last.First.First.First.Value
                                    myReturnList.Add((strName, strValue))
                                End If
                            End If
                        Next
                    Next
                Next
                intCounter += 1
            Next
            frmProgressBar.UpdateLabel("Retrieving Interactions" & intCounter & " of " & propertyNames.Count)
            frmInventory.txtStatus.Text = ("Retrieving Interactions" & intCounter & " of " & propertyNames.Count)
        Next

        Return myReturnList
    End Function


    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:GetInteractionsDispense           */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/25/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to display a 
    '/* messagebox to the screen that contains a list of all interactions
    '/* that the selected drug as with other meds the patient is prescribed
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  Adhoc.InsertAdHoc()								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  strbSQL.Append()
    '/* strbSQL.Clear()
    '/* CreateDatabase.ExecuteScalarQuery
    '/* CreateDatabase.ExecuteSelectQuery
    '/* MessageBox.Show
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   
    '/*											   
    '/* intMedicationRXCUI		
    '/* IntPatientMRN
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*   GetInteractionsDispense("12345","2255")
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/* dsPatientInteractions
    '/* intMEDID
    '/* intPatientID
    '/* strDrugoneName
    '/* strDrugtwoName
    '/* strbInteractionsString
    '/* strbSQL
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/25/21  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub GetInteractionsDispense(ByRef intMedicationRXCUI As Integer, ByRef IntPatientMRN As Integer)

        Dim strbSQL As StringBuilder = New StringBuilder
        Dim intMEDID As Integer
        Dim intPatientID As Integer
        Dim dsPatientInteractions As DataSet
        Dim strbInteractionsString As StringBuilder = New StringBuilder
        Dim strDrugoneName As String
        Dim strDrugtwoName As String
        'using RXCUI get the medication ID from the database to use to find the interactions
        strbSQL.Append("SELECT Medication_ID FROM Medication WHERE RXCUI_ID = '" & intMedicationRXCUI & "'")
        intMEDID = CreateDatabase.ExecuteScalarQuery(strbSQL.ToString)
        strbSQL.Clear()
        'using MRN number get patient ID for getting prescribed meds for interactions
        strbSQL.Append("SELECT Patient_ID FROM Patient WHERE MRN_Number = '" & IntPatientMRN & "'")
        intPatientID = CreateDatabase.ExecuteScalarQuery(strbSQL.ToString)
        strbSQL.Clear()

        strbSQL.Append("Select Medication_One_ID,Medication_Two_ID,Severity,Description From Drug_Interactions ")
        strbSQL.Append("Inner join Medication ")
        strbSQL.Append("ON Medication.Medication_ID = Drug_Interactions.Medication_One_ID ")
        strbSQL.Append("Inner Join PatientMedication ")
        strbSQL.Append("ON PatientMedication.Medication_TUID = Drug_Interactions.Medication_One_ID ")
        strbSQL.Append("WHERE PatientMedication.Patient_TUID = '" & intPatientID & "' ")
        strbSQL.Append("AND PatientMedication.Active_Flag = '1'")
        strbSQL.Append("AND Drug_Interactions.Active_Flag = '1'")
        dsPatientInteractions = CreateDatabase.ExecuteSelectQuery(strbSQL.ToString)


        For Each dr As DataRow In dsPatientInteractions.Tables(0).Rows
            strbSQL.Clear()
            strbSQL.Append("SELECT Drug_Name FROM Medication WHERE Medication_ID = '" & dr(0) & "'")
            strDrugoneName = CreateDatabase.ExecuteScalarQuery(strbSQL.ToString)
            strbSQL.Clear()
            strbSQL.Append("SELECT Drug_Name FROM Medication WHERE Medication_ID = '" & dr(1) & "'")
            strDrugtwoName = CreateDatabase.ExecuteScalarQuery(strbSQL.ToString)

            strbInteractionsString.AppendLine(strDrugoneName & " interacts with " & strDrugtwoName)
            strbInteractionsString.AppendLine("Severity: " & dr(2))
            strbInteractionsString.AppendLine("Descriptions: " & dr(3))
            strbInteractionsString.AppendLine("")
            frmProgressBar.UpdateLabel("Checking interaction records")
        Next

        If (strbInteractionsString.Length > 0) Then
            MessageBox.Show(strbInteractionsString.ToString)
        Else
        End If



    End Sub


End Module
