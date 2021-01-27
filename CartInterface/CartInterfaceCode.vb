﻿Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Threading
Module CartInterfaceCode
    '/*********************************************************************/
    '/*                   FILE NAME: CartInterfaceCode                    */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: CartInterface  				   */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		               */		  
    '/*		         DATE CREATED:	1/21/2021                   		   */						  
    '/*********************************************************************/
    '/*  PROJECT PURPOSE:								   */				  
    '/*	This is going to handle the interface actions the program has with */
    '/* the cart. When the program gets a drawer number it will conver the */
    '/* draw number into a string the cart is expecting, and then will send */
    '/* that information to the cart. 
    '/* 																	  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									   */			  
    '/*	 this is going to contain the actual code for the interface.      */					  
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
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                    */	
    '/*  BitRate as integer - this is going to be the bit per second that are going to */
    '/*     Transmitted to the cart. By default it will be 115200 and shouldn't*/
    '/*     need to be changed at any time.                                 */
    '/*  DefaultCOM as string - this is the default COM port that the interface*/
    '/*     will use if a different one is not provided. 
    '/*	 SimulationMode as boolean - this is going to be a true or false   */ 
    '/*     statement that will tell us if we are simulating the cart.     */
    '/*     If we are simulating the cart then the code that works with the */
    '/*     cart will not compile.  */
    '/*     
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

    '26
    Const bitRate = 115200
    Const DefaultCOM As String = "COM3"


    'TODO
    'set up a way to change the COM port. (by default it looks like it is COM3
    'default bit rate looks to be 115200
#Const SimulationMode = True 'this is going to dictate if the cart is going to be simulated or not.
    Sub main()
        OpenDrawer(16)


    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: OpenDrawer 					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 		   */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								   */             
    '/*	 This is going to handle taking the drawer number that the calling */
    '/* coding wants to open. It will then take the code, converts it to the */
    '/* string into what the cart is expecting. If the code is compiled in */
    '/* simulation it won't make the string and will pop up a window acting */
    '/* like the drawer has beem opened.                                    */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                        */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										                        */                 
    '/*             CartInterfaceCode.convertToHex					   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 Number - this is the sring of the drawer number that the calling */
    '/*     calling code wants to open. 
    '/*                                                                     
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	OpenDrawer(13)        										   */     
    '/* OpenDrawer(2)                                                     */
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 frmCart - this is the form that is going be be used to simulate the  */
    '/*     the cart. It will display what drawer is open and will give the */
    '/*     caller an option to close the drawer. 
    '/*  comPort - this is the port that is going to be used to connect to the */
    '/*     cart. 
    '/*  dicHexDictioanry - this is the dictionary that is going to hold the */
    '/*     hex converstion that are going to be sent to the cart.           */
    '/*     A dictionary was used because I could not figure out how to get  */
    '/*     visual basic to convert a string over to a hex correctly. So I just */
    '/*     made a dictionary that would do it. 
    '/*  bytFinal - this is the byte array that the drawer number is going to */
    '/*     be added into and sent to the cart itself. Most of the array is   */
    '/*     is static and doesn't need to change. The only part that needs to */
    '/*     is the drawer number. 
    '/*  blnIssue - this is going to let the rest of the program know */
    '/*     if there is an issue with the import and the subprogram needs to */
    '/*     be stopped. 
    '/*  blnNaN - this is for the Not a Number Error. The name is taken */
    '/*     from JavaScript. If the SubProgram is sent something that doe not */
    '/*     convert to a number, both this and issue will be marked as true */
    '/*  blntoHigh - this is for when the number is higher then the */
    '/*     number of drawer we have. We only have 26 drawers. So if a number */
    '/*     higher than 26 is passed to the Subprogram both this and issue */
    '/*     will be marked as true.
    '/*  blntoLow - this is for when the number is lower than 1.    */
    '/*     We do not have negative drawers and our drawer count starts at 1. */
    '/*     So anything lower is going to cause this and issue to be marked */
    '/*     as true. 
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Sub OpenDrawer(Number As String)
        Dim blnissue = False
        Dim blntoHigh = False
        Dim blntoLow = False
        Dim blnNaN = False

        If Not IsNumeric(Number) Then
            blnNaN = True
            blnissue = True
        Else
            If Convert.ToInt32(Number) > 26 Then
                blntoHigh = True
                blnissue = True
            ElseIf Convert.ToInt32(Number) < 1 Then
                blntoLow = True
                blnissue = True
            End If
        End If
        Dim FrmCart = New FrmCart

#If SimulationMode Then
        'this will comiple and be ran if the code is compiled in simulation mode. 

        If Not blnissue Then
            FrmCart.LblDrawer.Text = "Drawer Number " + Number + " is Open"
            FrmCart.ShowDialog()
        End If
#Else
        If Not blnissue Then

            'this will compiple and run if the cart is not in simulation mode. 
            Dim dicHexDictioanry = New Dictionary(Of String, System.Int32)
            Dim bytFinal As Byte()

            Dim comPort
            populationDictionary(dicHexDictioanry)



            If Number.Length > 1 Then
                If Number.Substring(0, 1) = 1 Then 'this is going to be for when the drawer number is greater 
                    'then 9
                    'handles 10 through 19
                    bytFinal = {&H32, &H30, &H35, &H39, &H36, &H32, &H35, &H2C, &H4F, &H2C, &H30, &H2C, &H31, dicHexDictioanry.Item(Number.Substring(1)), &H0}
                ElseIf Number.Substring(0, 1) = 2 Then
                    'handles 20 through 29
                    bytFinal = {&H32, &H30, &H35, &H39, &H36, &H32, &H35, &H2C, &H4F, &H2C, &H30, &H2C, &H32, dicHexDictioanry.Item(Number.Substring(1)), &H0}
                End If
            Else
                'handles 1 through 9
                bytFinal = {&H32, &H30, &H35, &H39, &H36, &H32, &H35, &H2C, &H4F, &H2C, &H30, &H2C, dicHexDictioanry.Item(Number), &H0}

            End If



            comPort = DefaultCOM
            'this is going to set everything up with the cart. 
            With FrmCart
                .SerialPort1.PortName = comPort
                .SerialPort1.BaudRate = bitRate
                .SerialPort1.RtsEnable = False
                .SerialPort1.DtrEnable = False
                'StopBits: 1 Parity: NONE WordLength: 8
                .SerialPort1.StopBits = StopBits.One
                .SerialPort1.Parity = Parity.None
                .SerialPort1.DataBits = 8
                .SerialPort1.WriteTimeout = 500
                .SerialPort1.ReadTimeout = 500
                .SerialPort1.Handshake = Handshake.None
                .SerialPort1.Open()
                .SerialPort1.Write(bytFinal, 0, bytFinal.Length)
                .SerialPort1.ReadExisting() 'this is to make sure the program doesn't continue until drawer is closed. 
                .SerialPort1.Close()
            End With
        End If

#End If
        'this is going to show an error message is there is an issue. 
        If blnissue Then
            If blntoHigh Then
                MessageBox.Show(Number & " is greater than the max number of drawers. There are only 26 drawers in this cart model")
            ElseIf blntoLow Then
                MessageBox.Show(Number & " is not a vaild drawer number. A drawer number must be between 1 and 26")
            ElseIf blnNaN Then
                MessageBox.Show(Number & " is not a vaild number.")

            End If
        End If
    End Sub

#If SimulationMode = False Then
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: populationDictionary			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 1/25/2021 		   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is going to populate the dictory that is used to store the  */
    '/*  hex value that Visual Basic is expecting when we are making the  */
    '/*  the bytes arrays that are being sent to the cart. It is only going */
    '/*  contain the numbers one through nine. As the rest are just repeated.*/
    '/*  It is going going to be skipping drawer 2 because we don't have a */
    '/*  drawer 2. 
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*            CartInterfaceCode.OpenDrawer()         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*		(dicHexDictioanry As Dictionary(Of String, System.Int32) -       */ 
    '/*         This is the dictionary that we are going to be populating */
    '/*         with the hex values
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*   populationDictionary(hexDictioanry)                                                                  
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


    Sub populationDictionary(ByRef dicHexDictioanry As Dictionary(Of String, System.Int32))
        With dicHexDictioanry
            .Add("0", &H30)
            .Add("1", &H31)
            .Add("2", &H32)
            .Add("3", &H33)
            .Add("4", &H34)
            .Add("5", &H35)
            .Add("6", &H36)
            .Add("7", &H37)
            .Add("8", &H38)
            .Add("9", &H39)
        End With
    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		         */   
    '/*		         DATE CREATED: 		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*											   */                     
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
    Sub ChangeSettings()

    End Sub

#End If


End Module
