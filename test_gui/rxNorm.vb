Imports System.Net
Imports RestSharp
Module rxNorm
    '/*******************************************************************/
    '/*                   FILE NAME:  rxNorm.vb                         */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  Dillen Perron    		        */
    '/*		         DATE CREATED: January 27, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module will allow the application to pull a RESTcall       */
    '/* to the web api and return the drug information including the    */  
    '/* rxUI number                                                     */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                                                    (NONE)	    */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                          (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/*                                                                 */
    '/*******************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                */
    '/*						  	 (NONE)			                        */
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
    '/*  WHO            WHEN        WHAT								*/
    '/*  Dillen    1/27/2021   Initial creation                         */
    '/*******************************************************************/







    '/*********************************************************************/
    '/*                   FUNCTION NAME:  getDrugInformationByName        */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: 2/3/2021     			              */
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */
    '/*											                          */
    '/* This function Is responsible for making rxNorm api call           */
    '*/ to gather drug information                                        */
    '/*											                          */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*                                     				              */
    '/*********************************************************************/
    '/*  CALLS:										                      */
    '/*             (NONE)								                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/*											                          */
    '/* 			                                                      */
    '/*********************************************************************/
    '/*  RETURNS:								                          */
    '/*            (NOTHING)								              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */
    '/*											                          */
    '/* getDrugInformationByName("tylenol")  		                      */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):			    	          */
    '/*											                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO      WHEN     WHAT								              */
    '/*                                                                   */
    '/*  Dillen  01/27/21  Function to make api call to get               */
    '/*                      drug information.			                  */
    '/* NP       02/9/2021 Changed function to return result to remove the*/
    '/*                    Warning for not returning a value.             */
    '/*********************************************************************/


    Function getDrugInformationByName(drugname As String) As Object


        'URL for finding each drug name 
        Dim url As String = "https://rxnav.nlm.nih.gov/REST/drugs?name=" + drugname


        'web request to pull data 
        Dim restClient As New RestSharp.RestClient(url)
        Dim restRequest As New RestSharp.RestRequest(url)


        'saves the result from request
        Dim result = restClient.get(restRequest)


        'debug to test if content is correct
        Debug.WriteLine(result.Content)
        'changed function to return result to remove warning. NP
        Return result
    End Function



    '/*********************************************************************/
    '/*                   FUNCTION NAME:  getDrugInformationByID        */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: 2/3/2021     			              */
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */
    '/*											                          */
    '/* This function Is responsible for making rxNorm api call           */
    '*/ to gather drug information                                        */
    '/*											                          */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*                                     				              */
    '/*********************************************************************/
    '/*  CALLS:										                      */
    '/*             (NONE)								                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/*											                          */
    '/* 			                                                      */
    '/*********************************************************************/
    '/*  RETURNS:								                          */
    '/*            (NOTHING)								              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */
    '/*											                          */
    '/*   getDrugInformationByID(153008)				                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):			    	          */
    '/*											                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO      WHEN     WHAT								              */
    '/*                                                                   */
    '/*  Dillen  01/27/21  Function to make api call to get               */
    '/*                      drug information using rxcui.			      */
    '/*********************************************************************/

    'Function getDrugInformationByID(drugid As String) As Object


    'URL for finding each drug name 
    'Dim url As String = "https://rxnav.nlm.nih.gov/REST/rxcui/" + drugid+ "/filter?propName=TTY&propValues=IN+PIN"


    'web request to pull data 
    'Dim restClient As New RestSharp.RestClient(url)
    'Dim restRequest As New RestSharp.RestRequest(url)


    'saves the result from request
    'Dim result = restClient.get(restRequest)


    'debug to test if content is correct
    '   Debug.WriteLine(result.Content)

    '  End Function
    '/*********************************************************************/
    '/*                   FUNCTION NAME:  getAllProperties                */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: 2/3/2021     			              */
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */
    '/*											                          */
    '/* This function Is responsible for gathering all property           */
    '/*	information on a given rxcui number		                          */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*                                     				              */
    '/*********************************************************************/
    '/*  CALLS:										                      */
    '/*             (NONE)								                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/*											                          */
    '/* 			                                                      */
    '/*********************************************************************/
    '/*  RETURNS:								                          */
    '/*            (NOTHING)								              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */
    '/*											                          */
    '/*   getAllProperties("153008")				                  */
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
    '/*  Dillen  01/27/21  Function to make api call to get               */
    '/*                      drug properties            			      */
    '/*  NP      02/9/2021 Added a return that returns the result to      */
    '/*                    remove the function has no return warning.     */
    '/*********************************************************************/

    Function getAllProperties(rxcuiNum As String)
        'Url of the API call for all properties
        Dim url As String = "https://rxnav.nlm.nih.gov/REST/rxcui/" + rxcuiNum + "/allProperties.json?prop=all"


        'web request to pull data 
        Dim restClient As New RestSharp.RestClient(url)
        Dim restRequest As New RestSharp.RestRequest(url)


        'saves the result from request
        Dim result = restClient.get(restRequest)


        'debug to test if content is correct
        Debug.WriteLine(result.Content)
        'adding return result to make this work like a function -NP
        Return result
    End Function


    '/*********************************************************************/
    '/*                   FUNCTION NAME:  getDrugRXCUI                    */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: 2/3/2021     			              */
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */
    '/*											                          */
    '/* This function is a Search for a name in the RxNorm data set and   */
    '/* Return the RxCUIs Of any concepts which have that name As an      */
    '/* RxNorm term Or As a synonym Of an RxNorm term. Search option      */
    '/* is a normalized String search. (search = 1)                       */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*                                     				              */
    '/*********************************************************************/
    '/*  CALLS:										                      */
    '/*             (NONE)								                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/*											                          */
    '/* 			                                                      */
    '/*********************************************************************/
    '/*  RETURNS:								                          */
    '/*            (NOTHING)								              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */
    '/*											                          */
    '/*   getDrugRXCUI("advil","200","mg","Tab")				          */
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
    '/*  Dillen  02/4/21  inital creation                                 */
    '/*  NP      02/9/2021 Added a return that returns the result to      */
    '/*                    remove the function has no return warning.     */
    '/*********************************************************************/
    Function getDrugRXCUI(drugName As String, drugDosage As String, drugMeasurement As String, drugType As String) As Object


        'URL for finding each drug name 
        'Dim url As String = "https://rxnav.nlm.nih.gov/REST/drugs?name=" + searchName
        Dim url As String = "https://rxnav.nlm.nih.gov/REST/rxcui.json?name=" + drugName + "+" + drugDosage + "+" + drugMeasurement + "+" + drugType + "&search=1"

        'web request to pull data 
        Dim restClient As New RestSharp.RestClient(url)
        Dim restRequest As New RestSharp.RestRequest(url)


        'saves the result from request
        Dim result = restClient.Get(restRequest)


        'debug to test if content is correct
        Debug.WriteLine(result.Content)
        'adding return result to make this work like a function -NP
        Return result
    End Function

End Module