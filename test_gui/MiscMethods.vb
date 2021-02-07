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
Imports System.Text
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
    '/*	MiscMethods.PopulateStateComboBox(cboStates)    				   */                     
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
    '/*                   FUNCTION NAME: checkComboForDup                  */         
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
    '/*   item - This is the string that you wish to add to the combobox    */                                                                  
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*	blnGood - this is the value that will tell us if the item is unqiue*/  
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/* MiscMethods.checkComboForDup(cboStates, "MI)                       */
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


    Function checkComboForDup(cboRoom As ComboBox, item As String)
        Dim blnGood As Boolean = True
        For Each thing As String In cboRoom.Items
            If thing.Equals(item) Then
                blnGood = False
            End If
        Next
        Return blnGood
    End Function


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  PopulateRoomComboBox 	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 2/6/2021                     		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								               */             
    '/*	 This is going to populate a combo box with the list of rooms that */
    '/*  are in our database.                                              */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	cboRoom - this is the combo box that we are going to be populating*/
    '/* dsrooms- this is the dataset of the rooms that we are going to be */
    '/*     using. 
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*	miscMethods.PopulateRoomComboBox(CboRooms, dsRooms)										   */                     
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

    Sub PopulateRoomComboBox(cboRoom As ComboBox, dsrooms As DataSet)
        For Each row As DataRow In dsrooms.Tables(0).Rows
            If checkComboForDup(cboRoom, row(EnumList.room.Id)) Then
                cboRoom.Items.Add(row(EnumList.room.Id))
            End If
        Next
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: populateBedComboBox  		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:						            		   */             
    '/*	This is going to populate a combo box with the list of rooms that  */                     
    '/* we have in our database. It is only going to post the unique ones. */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*											   */                     
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


    Sub populateBedComboBox(cboBed As ComboBox, dsrooms As DataSet)
        For Each row As DataRow In dsrooms.Tables(0).Rows
            If checkComboForDup(cboBed, row(EnumList.room.BedName)) Then
                cboBed.Items.Add(row(EnumList.room.BedName))
            End If
        Next
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: populatePhysicianComboBox      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                */   
    '/*		         DATE CREATED: 	2/6/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:						            		   */             
    '/*	This is going to populate a combo box with the list of Physicians that*/                     
    '/* we have in our database. It is only going to post the unique ones. */           
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 cboStuff - This is going to be the combo box that we are trying   */
    '/*     populate with the list of physicians.                          */
    '/*  ds - this is the data that we are using to populate the combo box */                                                                     
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


    Sub populatePhysicianComboBox(cboStuff As ComboBox, ds As DataSet)
        Dim strbTesting As New StringBuilder
        For Each row As DataRow In ds.Tables(0).Rows
            strbTesting.Clear()
            strbTesting.Append((row(EnumList.Physician.FirstName) & " " &
                                row(EnumList.Physician.LastName)))
            If checkComboForDup(cboStuff, strbTesting.ToString) Then
                cboStuff.Items.Add(strbTesting.ToString)
            End If
        Next
    End Sub

End Module
