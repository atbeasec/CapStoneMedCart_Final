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
    '/*  Dillen    1/27/2021   Initial creation                    */
    '/*******************************************************************/

    'stores name of rxui
    Dim strRXUI As String
    'stores the name of the drug the user is trying to search 
    Dim searchName As String




    '/*********************************************************************/
    '/*                   FUNCTION NAME:  getDrugInformation              */
    '/*********************************************************************/
    '/*                   WRITTEN BY:Dillen Perron  		              */
    '/*		         DATE CREATED: January 16, XXXX			              */
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
    '/*   CalcQuadratic(4.0,5.0,6.0);					                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):			    	          */
    '/*											                          */
    '/*  sngDisc – The calculated discriminant of the quadratic equation. */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO      WHEN     WHAT								              */
    '/*                                                                   */
    '/*  Dillen  01/27/21  Function to make api call to get               */
    '/*                      drug information.			                  */
    '/*********************************************************************/


    Function getDrugInformation(drugname As String) As Object


        'URL for finding each drug name 
        Dim url As String = "https://rxnav.nlm.nih.gov/REST/drugs?name=" + searchName


        'web request to pull data 
        Dim restClient As New RestSharp.RestClient(url)
        Dim restRequest As New RestSharp.RestRequest(url)


        'saves the result from request
        Dim result = restClient.get(restRequest)


        'debug to test if content is correct
        Debug.WriteLine(result.Content)

    End Function


End Module