Public Class FrmCart
    '/*********************************************************************/
    '/*                   FILE NAME:  FrmCart                             */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: CartInterface  				   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		                 */		  
    '/*		         DATE CREATED:	1/21/2021                   		   */	
    '/*********************************************************************/
    '/*  FILE PURPOSE:									   */			  
    '/*	 This is going to be the form that is used to simulate the cart.  */
    '/* is just has a label that will be changed to the drawer number, and */
    '/* a button that closes the form. 
    '/* 																	  
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
    '/*                   SUBPROGRAM NAME:  btnClose_Click				   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                */   
    '/*		         DATE CREATED: 	1/21/2021                       	   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*	 this is going to handle the when the button on the form is clicked*/
    '/*  all it will do is close the form by calling the me.close function. */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      	               					         */           
    '/*  The button on the form.                          				   */         
    '/*********************************************************************/
    '/*  CALLS:										                       */                 
    '/*             (NONE)							                	   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				        	   */         
    '/*			(NONE)                  								   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								                           */                   
    '/*            (NOTHING)							               	   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*		(None)                  									   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
