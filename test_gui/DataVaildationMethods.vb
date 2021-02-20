﻿Module DataVaildationMethods
    '/*********************************************************************/
    '/*                   FILE NAME:  DataVaildationMethods                 */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: Test_Gui				   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		                   */		  
    '/*		         DATE CREATED: 2/17/2021                        	   */						  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									   */			  
    '/*	 This is going to contain the reusable methods to vailidating data.*/
    '/*  Things like checking keypresses and other things.                 */
    '/* 																	  
    '/*********************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			   */ 
    '/*                                                    (NONE)	   */	  
    '/*********************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							   */			  
    '/*                          (NOTHING)					   */		  
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
    '/*                   SUBPROGRAM NAME:  KeyPressCheck   			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/17/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:							            	   */             
    '/*  This is going to check to see if the key being pressed is part of */
    '/*  The allowed characters. All you need to do is give it the         */
    '/*  KeyPressEventArgs and the a string of the characters you want to  */
    '/*  allow and it will handle the rest. It was made beause where was a */
    '/*  lot of reduntant code that could be reused for checking keypresses*/
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 e - this is the key press event args that are generated when a key*/
    '/*      press happens.                                                */
    '/* AllowChars - this is a string of the characters you want to be able*/
    '/*              to allow.                                             */
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



    Sub KeyPressCheck(ByRef e As KeyPressEventArgs, AllowChars As String)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not AllowChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub



    '/**********************************************************************/
    '/*                   SUBPROGRAM NAME:  KeyPressCheck   			   */         
    '/**********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		           */   
    '/*		         DATE CREATED: 	2/19/2021                       	   */                             
    '/**********************************************************************/
    '/*  SUBPROGRAM PURPOSE:							            	   */             
    '/*  This is going to check to the quantity of the medication that is  */
    '/*  currently stocked in the cart and ensure that the user cannot     */
    '/*  increment the medication button past the value we have stored.    */
    '/*                                                                    */
    '/**********************************************************************/
    '/*  CALLED BY:   	      						                       */           
    '/*                                         				           */         
    '/**********************************************************************/
    '/*  CALLS:										                       */                 
    '/*             (NONE)								                   */             
    '/**********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					           */         
    '/*	 limit- integer equal to the quantity of that medication stored    */
    '/*  txtBoxQuantity- the textbox that is used to contain the qty value */                                                                  
    '/**********************************************************************/
    '/*  RETURNS:								                           */                   
    '/*            (NOTHING)								               */             
    '/**********************************************************************/
    '/* SAMPLE INVOCATION:								                   */             
    '/*											                           */                     
    '/**********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):     */
    '/* None                                                               */     
    '/**********************************************************************/
    '/* MODIFICATION HISTORY:						                       */               
    '/*											                           */                     
    '/*  WHO         WHEN           WHAT								   */             
    '/*  ck          2/19/21        Creation                               */
    '/*********************************************************************/
    Sub LimitQuantityToQuantityStocked(ByVal limit As Integer, ByVal txtBoxQuantity As TextBox)

        If CInt(txtBoxQuantity.Text) > limit Then
            ' set the value to the limit because the user cannot dispense more than the cart contains
            txtBoxQuantity.Text = limit
            MessageBox.Show("The cart only contains " & limit & " of this medication. Please restock or pick a smaller quantity.")
        End If

    End Sub


End Module
