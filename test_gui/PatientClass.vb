Public Class PatientClass
    Inherits PersonClass
    '/*********************************************************************/
    '/*                   FILE NAME:  PatientClass                        */									  
    '/*********************************************************************/
    '/*                 PART OF PROJECT: Test_GUI				          */				  
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo  		              */		  
    '/*		         DATE CREATED:	3/3/2021                    		  */						  
    '/*********************************************************************/
    '/*  FILE PURPOSE:									                   */			  
    '/*	 This is going to be the Class used to make the patient object when*/
    '/*  We read in files. 
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
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                  */		  
    '/*	                                                                  */
    '/* strBarcode - this is the bar code that will be used with the badge.*/
    '/* strDob - this is the date of birth for the patient.                */
    '/* intHeight - this is the height of the patient.                     */
    '/* lngMRN_Number - This is the MRN of the patient. It is a long as I am*/
    '/*         not sure how long the number will need to be.              */
    '/* lngPrimaryPhysicianID - this is the ID of the physician that is    */
    '/*                 taking care of them. It is a long as I am not sure */
    '/*                 how long the IDs will be.                          */
    '/* strSex - this is the sex of the patient. It will either be male or */
    '/*          Female.                                                   */
    '/* intWeight - this is the weight of the patient.   				   */					  
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


    Dim lngMRN_Number As Long
    Dim strBarcode As String
    Dim strDob As String
    Dim strSex As String
    Dim intHeight As Integer
    Dim intWeight As Integer
    Dim lngPrimaryPhysicianID As Long


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  New					          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 		3/3/2021                           */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is the constructor for the class.         				   */                     
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

    Public Sub New(lngMRN_Number As Long, strBarcode As String, strFirstName As String, strMiddleName As String, strLastName As String, strDoB As String,
                   strSex As String, intHeight As Integer, intWeight As Integer, strPhoneNumber As String, strAddress As String, strState As String, strZip As String,
                   lngPrimaryPhysicianID As Long)
        MyBase.New(strFirstName, strMiddleName, strLastName, strPhoneNumber, strAddress, strState, strZip)
        Me.MRN_Number = lngMRN_Number
        Me.barcode = strBarcode
        Me.DoB = strDoB
        Me.sex = strSex
        Me.Height = intHeight
        Me.weight = intWeight
        Me.PrimaryPhysicianID = lngPrimaryPhysicianID
    End Sub


    '/*********************************************************************/
    '/*                   Property NAME: MRN_Numbe   					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	3/3/2021                        	   */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:								                   */             
    '/*	 This is the Getter and setter for lngMRN_Number    			   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					         */         
    '/*	 MRN_Number- this is the value that is going to be assigned to    */
    '/*            lngMRN_Number*/                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								                           */                   
    '/*            lngMRN_Number        								   */             
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

    Public Property MRN_Number As Long
        Get
            Return lngMRN_Number
        End Get
        Set(value As Long)
            lngMRN_Number = value
        End Set
    End Property


    '/*********************************************************************/
    '/*                   Property NAME:  barcode   					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	3/3/2021                        	   */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:								                    */             
    '/*	 This is the getter and setter for strBarcode   				   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 barcode - this is the value that is going to be assigned to barcode*/                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            strBarcode								   */             
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

    Public Property barcode As String
        Get
            Return strBarcode
        End Get
        Set(value As String)
            strBarcode = value
        End Set
    End Property

    '/*********************************************************************/
    '/*                   Property NAME: DoB 					         */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		              */   
    '/*		         DATE CREATED: 	3/3/2021                        	   */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:							                	   */             
    '/*	 This is the getter and setter for strDob   					   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					           */         
    '/*	 DoB this is the value that is going to be assigned to strDob      */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            strDob								   */             
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


    Public Property DoB As String
        Get
            Return strDob
        End Get
        Set(value As String)
            strDob = value
        End Set
    End Property

    '/*********************************************************************/
    '/*                   Property NAME:  sex					            */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 3/3/2021		                         */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:								                   */             
    '/*	 This is the getter and setter for strSex   					   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sex - this is the value that is going to be assigned to strSex   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            strSex								   */             
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

    Public Property sex As String
        Get
            Return strSex
        End Get
        Set(value As String)
            strSex = value
        End Set
    End Property

    '/*********************************************************************/
    '/*                   Property NAME:  	Height				           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		             */   
    '/*		         DATE CREATED: 	3/3/2021                        	   */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:								                    */             
    '/*	 This is the getter and setter for intHeight    				   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				        	   */         
    '/*	 Height	- this is the value that is going to be assigned to intHeight*/                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            intHeight								   */             
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


    Public Property Height As Integer
        Get
            Return intHeight
        End Get
        Set(value As Integer)
            intHeight = value
        End Set
    End Property


    '/*********************************************************************/
    '/*                   Property NAME:  weight    					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		                 */   
    '/*		         DATE CREATED: 3/3/2021                     		   */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:								   */             
    '/*	 This is the getter and setter for 	intWeight   				   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					           */         
    '/*	 weight	- this is the value that is going to be assigned to intWeight*/                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            intWeight								   */             
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

    Public Property weight As Integer
        Get
            Return intWeight
        End Get
        Set(value As Integer)
            intWeight = value
        End Set
    End Property

    '/*********************************************************************/
    '/*                   Property NAME:  	PrimaryPhysicianID  		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		              */   
    '/*		         DATE CREATED: 		3/3/2021                            */                             
    '/*********************************************************************/
    '/*  Property PURPOSE:								   */             
    '/*  This is the getter and setter for lngPrimaryPhysicianIDd     	   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 PrimaryPhysicianID	- this is the value that is going to be assigned*/
    '/*                     to lngPrimaryPhysicianID                        */
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*        lngPrimaryPhysicianID    								   */             
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


    Public Property PrimaryPhysicianID As Long
        Get
            Return lngPrimaryPhysicianID
        End Get
        Set(value As Long)
            lngPrimaryPhysicianID = value
        End Set
    End Property
End Class
