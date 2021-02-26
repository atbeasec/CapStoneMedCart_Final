Imports RestSharp
Imports Newtonsoft.Json.Linq
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
    '/*    getInteractionsByName("153010")		        			          */
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
    '/*********************************************************************/
    Function getInteractionsByName(rxcuiNum As String, propertyNames As List(Of String)) As List(Of (PropertyName As String, PropertyValue As String))
        'URL for finding interactions 
        Dim url As String = $"https://rxnav.nlm.nih.gov/REST/interaction/interaction.json?rxcui={rxcuiNum}"
        'location in json of properties
        Dim trawlPointer As String = "$.interactionTypeGroup[0].interactionType[0].interactionPair"
        Dim trawlPointerRxcui As String = "$.interactionTypeGroup[0].interactionType[0].interactionPair.interactionConcept"
        'inputJSON
        Dim inputJSON As JToken = rxNorm.GetJSON(url)
        'set Jtoken into array to pull data from json
        'Dim trawledResult As JToken = inputJSON.SelectToken(trawlPointer)
        Dim JsonJArray As JArray = inputJSON.SelectToken(trawlPointer)
        Dim JsonJArrayRxcui As JArray = inputJSON.SelectToken(trawlPointerRxcui)
        'Stores our List of properties selected 
        Dim myReturnList As New List(Of (PropertyName As String, PropertyValue As String))
        Dim strName As String
        Dim strValue As String
        'Dim arrJson As JArray = JObject.Parse(JsonJArray)

        For Each propertyName As String In propertyNames
            For Each item As JObject In JsonJArray
                JsonJArrayRxcui = inputJSON.SelectToken(trawlPointerRxcui)
                For Each subItem As JProperty In item.Children
                    For Each propertyIdentifier In propertyNames
                        If subItem.Name.ToString.ToUpper = propertyIdentifier.ToUpper Then
                            strName = subItem.Name
                            strValue = subItem.Value
                            myReturnList.Add((strName, strValue))
                            'myReturnList.Add((subItem.Value, DirectCast(subItem.Next, JProperty).Value))
                            'ElseIf subItem.minConceptItem.rxcui.value <> rxcuiNum Then

                            'y($"interactionConcept[1]")
                            'JObject.Parse(item) Then '  subItem.First.Value(Of JArray).Last.First.First.First.Name = propertyIdentifier Then
                            'strName = "rxcui" ' subItem.First.Value.Last.First.First.First.Name
                            'strValue = JsonJArray("interactionConcept")("1")("minConceptItem")("rxcui") 'subItem.First.Value.Last.First.First.First.Value
                            ' myReturnList.Add((strName, strValue))
                        End If
                    Next
                Next
            Next
        Next

        ' or make another thrawler pointer and make another nested loop series.

        'For Each
        Debug.WriteLine(myReturnList.ToString)
        Return myReturnList
    End Function
End Module
