﻿Imports System.IO.Ports
Imports System.Data.SQLite
Imports Microsoft.Data.Sqlite
Public Class frmFullCart

    '/*********************************************************************/
    '/*                   FILE NAME:  FullCart                              */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: CartInterface  				   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		                */		  
    '/*		         DATE CREATED: 1/28/2021                			   */						  
    '/*********************************************************************/
    '/*  FILE PURPOSE:		
    '/*	 This is going to be the form that is used to simulate the cart.  */
    '/* is just has a label that will be changed to the drawer number, and */
    '/* a button that closes the form. 			                            */  
    '/*											   */					  
    '/* 																	  
    '/*********************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			         */ 
    '/*                                                    (NONE)	        */	  
    '/*********************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                   */			  
    '/*                          (NOTHING)					               */		  
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   */			  
    '/*			 FullCart.Show()		                             */					  
    '/* 																	  
    '/*********************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                    */
    '/*  BitRate as integer - this is going to be the bit per second that are going to */
    '/*     Transmitted to the cart.                                */
    '/*  comPort - this is the port that is going to be used to connect to the */
    '/*     cart. 
    '/*	                                                              */				  
    '/*********************************************************************/
    '/* COMPILATION NOTES(will include version notes including libraries):*/
    '/* 										                    	   */					  
    '/* 																	  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */				  
    '/*											   */					  
    '/*  WHO   WHEN     WHAT								   */			  
    '/*  ---   ----     ------------------------------------------------- */
    '/*********************************************************************/
    Dim bitRate
    Dim comPort


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  	Color_Click		     	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		             */   
    '/* SUBPROGRAM PURPOSE:		                						   */             
    '/* This is going to simulate the coloring of the drawer. When a drawer*/
    '/* is open it will turn red. When it is closed by clicking the drawer */
    '/* it will return back to the orginal color.                          *?
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                       */           
    '/*           Drawer buttons on frmFullCart                            */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*  sender – Identifies which particular control raised the          */
    '/*          click event                                              */
    '/*  e – Holds the EventArgs object sent to the routine               */        
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                           */                   
    '/*            (NOTHING)								               */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   */             
    '/*											                           */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 blnClosing - this is going to keep track of if we are going to be*/
    '/*     closing the form or not. If none of the buttons are red the   */
    '/*     form will close. If a button is red, the form will stay open. */
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/



    Private Sub Color_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click,
            btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click,
            btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click, btn25.Click, btn26.Click
        'the idea for this is if any of the buttons are clicked they just chane the color, so 
        'the entire thing can be handled in one sub. 

        Dim blnClosing As Boolean = True
        sender.BackColor = btnColor.BackColor
        For Each item As Button In Controls 'this gets all the contorls on the form. There should only be buttons. 
            If Not item.BackColor = btnColor.BackColor Then 'an open drawer will be red so if it is the standard 
                'control color that means the drawer is closed. 
                blnClosing = False
            End If
        Next

        If blnClosing Then
            Me.Close()
        End If

    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  populateButtonDictionary      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                */   
    '/*		         DATE CREATED: 	1/28/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:	            							   */             
    '/*	This is going to populate the dictionary with the controls that will*/
    '/* be used to simualte the drawers. This was we will just be able to   */
    '/* find the button we need in the dictionary. The sub is in the form  */
    '/* because I could not figure out how to access the buttons from the  */
    '/* cartinterfaceCode module and make the diciontary there. So I just  */
    '/* made it here to side step the issue entirely.                       */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 dicButtonDictionary - this is the dictionary of the buttons that are */
    '/*     on the simuated cart form (FullCart). This is to just make things*/
    '/*     easier to read and avoid duplicated code.                      */                  
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
    Sub populateButtonDictionary(ByRef dicButtonDictionary As Dictionary(Of String, Control))
        With dicButtonDictionary
            .Add("1", btn1)
            .Add("3", btn3)
            .Add("4", btn4)
            .Add("5", btn5)
            .Add("6", btn6)
            .Add("7", btn7)
            .Add("8", btn8)
            .Add("9", btn9)
            .Add("10", btn10)
            .Add("11", btn11)
            .Add("12", btn12)
            .Add("13", btn13)
            .Add("14", btn14)
            .Add("15", btn15)
            .Add("16", btn16)
            .Add("17", btn17)
            .Add("18", btn18)
            .Add("19", btn19)
            .Add("20", btn20)
            .Add("21", btn21)
            .Add("22", btn22)
            .Add("23", btn23)
            .Add("24", btn24)
            .Add("25", btn25)
            .Add("26", btn26)
        End With
    End Sub


    '/*********************************************************************/
    '/*                   FUNCTION NAME:  serialSetup					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		             */   
    '/*		         DATE CREATED: 2/1/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*	 This is going to handle setting up the serial port for use . It   */
    '/*  will make the serial port. Edit the settings as needed, and then   */
    '/*  return the serial port.                                            */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                     */           
    '/*                                         			        	   */         
    '/*********************************************************************/
    '/*  CALLS:										                     */                 
    '/*             (NONE)								                 */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				        	   */         
    '/*											                         */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:						                   		         */                   
    '/*            SerialPort1			            					   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:			                					   */             
    '/*			serialSetup()           								   */                     
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

    Function serialSetup()

        'comport from the database. 
        'this is going to set everything up with the cart. 

        SerialPort1.PortName = comPort
        SerialPort1.BaudRate = bitRate
        SerialPort1.RtsEnable = False
        SerialPort1.DtrEnable = False
        'StopBits: 1 Parity: NONE WordLength:  8
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Parity = Parity.None
        SerialPort1.DataBits = 8
        SerialPort1.WriteTimeout = 500
        SerialPort1.ReadTimeout = 500000000
        SerialPort1.Handshake = Handshake.None

        Return SerialPort1
    End Function


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  	gettingConnectionSettings  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/2/2021                        	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:	            							   */             
    '/*	 This is going to connect to the database and it is going to get the*/
    '/*  settings for the comport and the Bitrate. It will them assign it */
    '/*  to the global veriables comPort and Bitrate.                     */
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

    Sub gettingConnectionSettings()







    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  listening					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 		2/2/2021   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*  This is going to be listening for information from the cart so   */ 
    '/* we can keep track of when the drawers are closing. 
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



    Sub listening() Handles SerialPort1.DataReceived
        CartInterface.minusDrawerCount()
    End Sub

End Class