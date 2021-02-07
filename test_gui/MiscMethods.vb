'/*********************************************************************/
'/*                   FILE NAME:  MiscMethods                          */									  
'/*********************************************************************/
'/*                 PART OF PROJECT:	Test_GUI        			   */				  
'/*********************************************************************/
'/*                   WRITTEN BY:  Nathan Premo  		         */		  
'/*		         DATE CREATED:	2/6/2021                       		   */						  
'/*********************************************************************/
'/*  FILE PURPOSE:									   */			  
'/*	 This is going to house miscellaneous methods that can be reused  */
'/*  but don't make sense to have anywhere else.                       */
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

Module MiscMethods
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  	PopulateStateComboBox  	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 	2/6/2021                        	   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*	 This is going to populate the state comboxbox on a number of forms.*/
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	cboState - this is the combobox we are putting the states in.      */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:					                			         */                   
    '/*            (NOTHING)				            				   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:		                   						   */             
    '/*	MiscMethods.StateArray()										   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 strStatesArray - this is going to hold the array of states that is*/
    '/*      that is going to be used to populate ComboBoxs
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Sub PopulateStateComboBox(cboState As ComboBox)
        Dim strStatesArray As String() = {"ME", "NH", "VT", "MA", "CT", "RI", "NY", "VA", "NC",
        "SC", "GA", "FL", "DE", "NJ", "OH", "MI", "IL", "IN", "IA", "KS", "NE", "OK",
        "TX", "AL", "TN", "MO", "ND", "SD", "WY", "MT", "ID", "NV", "WA", "OR", "CO",
        "NM", "AZ", "WV", "PA", "CA", "AR", "HI", "MN", "WI", "MD", "MS", "AK", "LA",
        "UT", "KY"}

        For Each item As String In strStatesArray
            cboState.Items.Add(item)
        Next

    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME: checkforDup                       */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		             */   
    '/*		         DATE CREATED: 2/6/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*  this is going to check	the combo box to make sure that we are only*/
    '/*  adding items that are unqiue                                      */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 cboRoom - this is the combo box we are trying to add the itme to. */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*	blnGood - this is the value that will tell us if the item is unqiue*/                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	blnGood - this is going to be true if the item trying to be added */
    '/*     is unquie. It will be false if it is a duplicate              */
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/


    Function checkforDup(cboRoom As ComboBox, item As String)
        Dim blnGood As Boolean = True
        For Each thing As String In cboRoom.Items
            If thing.Equals(item) Then
                blnGood = False
            End If
        Next
        Return blnGood
    End Function
End Module
