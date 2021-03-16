Public Class frmOpenedDrawer
    '/*********************************************************************/
    '/*                   FILE NAME:  frmOpenedDrawer                       */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: CartInterface  				   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		             */		  
    '/*		         DATE CREATED:	2/2/2021                    		   */						  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									                   */			  
    '/*  This is going to hold the form that lets the user know a drawer is*/
    '/*  open. It exists to give the user a way to indicate a crat is closed */
    '/*  if the cart should fail to report it correctly. 
    '/* 																	  
    '/*********************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			       */ 
    '/*                                                    (NONE)	       */	  
    '/*********************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                    */			  
    '/*                          (NOTHING)				            	   */		  
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:						                		   */			  
    '/*				(none)                  							   */					  
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
    '/*                   SUBPROGRAM NAME:  btnClose_Click    			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/2/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:						            		   */             
    '/*	 This is going to handle the user clicking the close button. 	   */
    '/*  it exists in case the cart doesn't corretly send the code that a */
    '/*  drawer has closed it will allow the user to indicate that a drawer */
    '/*  has been closed.                                                  */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*   Form button click                                				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */
    '/*  sender – Identifies which particular control raised the          */
    '/*          click event                                              */
    '/*  e – Holds the EventArgs object sent to the routine               */        
    '/*                                                                   */  
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:			                					   */             
    '/*		btnClose.click          									   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*		(none)									   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CartInterfaceCode.minusDrawerCount()
    End Sub

    Private Sub frmOpenedDrawer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class