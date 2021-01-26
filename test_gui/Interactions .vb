Module Interactions
    '/*******************************************************************/
    '/*                   FILE NAME: Interactions.vb                    */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*	The purpose of this is to handle all drug interactions in the   */
    '/* program. It will handle parsing the interactions from the       */
    '/* Rxnorm API and storing them into the database. It will also handle*/
    '/* alerting the user of an interactions between drugs that are     */
    '/* being dispensed and others the patient is prescribed.           */
    '/*                                                                 */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                         (NONE)	                                */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                        (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* the program will invoke this module when the program is pulling */
    '/* new and/or updating drug information from the RXnorm API. this module*/
    '/* will then use the API information to update and insert new      */
    '/* drug interactions into the database. The program will also invoke*/ 
    '/* this module when a user clicks to dispense a medication. When the*/ 
    '/* dispense option is clicked this module will be invoked to check the*/
    '/* database for any drug interactions between the dispensed drug and*/
    '/* any other medications that the patient is prescribed and push   */
    '/* and alert to the screen for any found interactions              */
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
    '/*  WHO                     WHEN        WHAT						*/
    '/*  Alexander Beasecker    1/25/2021   Initial creation            */
    '/*******************************************************************/
End Module
