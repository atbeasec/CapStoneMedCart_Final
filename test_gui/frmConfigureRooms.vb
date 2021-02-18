'/********************************************************************	*/
'/*                   FILE NAME:  frmConfigureRooms					    */
'/********************************************************************	*/
'/*					  PART OF PROJECT: 									*/
'/********************************************************************	*/
'/*                   WRITTEN BY:  Breanna Howey	  					*/
'/*					  DATE CREATED: February 17, 2021					*/
'/********************************************************************	*/
'/*  FILE PURPOSE:														*/
'/*																		*/
'/* This file serves as the driver for the function between clicking on
'/* the controls for adding and deleting rooms and beds.                */
'/********************************************************************	*/
'/*  COMMAND LINE PARAMETER LIST (In Parameter Order):					*/
'/*                                                    (NONE)			*/
'/********************************************************************	*/
'/*  ENVIRONMENTAL RETURNS:												*/
'/*                          (NOTHING)									*/
'/********************************************************************	*/
'/* SAMPLE INVOCATION:													*/
'/*																		*/
'/* This program is launched from (1) the Windows Start Menu, (2)		*/
'/* clicking on the FILENAME.EXE program icon or (3) entering the path	*/
'/* and FILENAME.EXE name in the Run box on the Windows Start Menu.		*/
'/********************************************************************	*/
'/*  GLOBAL VARIABLE LIST (Alphabetically):								*/
'/* (None)                                                              */
'/********************************************************************	*/
'/* COMPILATION NOTES:													*/
'/* 																	*/
'/* This project compiles normally under Microsoft Visual Basic .NET 4.7.2*/
'/* All one needs to do is open up the FILENAME project and compile.	*/
'/* No special compile options or optimizations were used.  No			*/
'/* unresolved warnings or errors exist under these compilation			*/
'/* conditions.															*/
'/********************************************************************	*/
'/* MODIFICATION HISTORY:												*/
'/*																		*/
'/*  WHO		WHEN		WHAT										*/
'/*  BRH        02/17/21   Initial creation of the code-------------	*/
'/********************************************************************	*/
Public Class frmConfigureRooms
    '/*******************************************************************/
    '/*                   SUBROUTINE NAME:     frmConfigureRooms_Load	*/
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   02/17/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to handle the process of showing
    '/* the rooms and the beds to the user upon form load.              */
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/* ShowRoomsBeds()										            */
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/* sender - Holds the object the program is sending to the routine */
    '/* e   - Stores other arguments passed to the routine.             */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	frmConfigurationLoad()	    								    */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*  BRH        02/17/21   Initial creation of the code-------------*/
    '/*******************************************************************/

    Private Sub frmConfigureRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowRoomsBeds()
    End Sub

    '/*******************************************************************/
    '/*                   SUBROUTINE NAME:     btnAddBed_Click         	*/
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   02/17/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to handle the process of adding
    '/* rooms and beds to the database. When the button is clicked, the*/
    '/* program will add the room and bed to the database from the text */
    '/* entered into the corresponding text boxes. Next, the room and bed
    '/* list boxes are cleared to allow for repopulation of data.       */
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/* AddRoomsBeds()          										*/
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/* sender - Holds the object the program is sending to the routine */
    '/* e   - Stores other arguments passed to the routine.             */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	frmAddBed_Click()	    								        */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*  BRH        02/17/21   Initial creation of the code-------------*/
    '/*******************************************************************/
    Private Sub btnAddBed_Click(sender As Object, e As EventArgs) Handles btnAddBed.Click
        AddRoomsBeds(txtRoom.Text, txtBed.Text, 1)
        txtRoom.Clear()
        txtBed.Clear()
    End Sub

    '/*******************************************************************/
    '/*                   SUBROUTINE NAME:     btnDeleteRoom_Click    	*/
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   02/17/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to handle the process of deleting
    '/* rooms from the database, when the delete room button is selected*/
    '/* In addition, the listboxes will repopulate withthe rooms and beds in*/
    '/* the database.                                                   */
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/* DeleteRoom               										*/
    '/* ShowRoomsBeds              										*/
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/* sender - Holds the object the program is sending to the routine */
    '/* e   - Stores other arguments passed to the routine.             */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	btnDeleteRoom()     	    								    */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*  BRH        02/17/21   Initial creation of the code-------------*/
    '/*******************************************************************/
    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click
        DeleteRoom(lstRooms.SelectedItem)
        ShowRoomsBeds()
    End Sub

    '/*******************************************************************/
    '/*                   SUBROUTINE NAME:     btnDeleteBed_Click    	*/
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   02/17/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to handle the process of deleting
    '/* beds from the database, when the delete bed button is selected  */
    '/* In addition, the listboxes will repopulate the rooms and beds in*/
    '/* the database.                                                   */
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/* DeleteBed                 										*/
    '/* ShowRoomsBeds              										*/
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/* sender - Holds the object the program is sending to the routine */
    '/* e   - Stores other arguments passed to the routine.             */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	btnDeleteBed()     	    								    */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*  BRH        02/17/21   Initial creation of the code-------------*/
    '/*******************************************************************/
    Private Sub btnDeleteBed_Click(sender As Object, e As EventArgs) Handles btnDeleteBed.Click
        DeleteBed(lstBeds.SelectedItem)
        lstRooms.Items.Clear()
        lstBeds.Items.Clear()
        ShowRoomsBeds()
    End Sub

    '/*******************************************************************/
    '/*                   SUBROUTINE NAME:    ShowRoomsBeds            	*/
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   02/17/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to handle the process of repopulating
    '/* the rooms and beds listboxes to show the user the current rooms */
    '/* and beds in the database. When called, the routine will clear the
    '/* boxes and select the new data from the database.                */
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/* ShowRooms                 										*/
    '/* ShowBeds              										    */
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	ShowRoomsBeds()     	    								    */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*  BRH        02/17/21   Initial creation of the code-------------*/
    '/*******************************************************************/
    Public Sub ShowRoomsBeds()
        lstRooms.Items.Clear()
        lstBeds.Items.Clear()
        ShowRooms("SELECT DISTINCT Room_ID FROM Rooms WHERE Active_Flag = 1 ORDER BY Room_ID ASC")
        ShowBeds("SELECT DISTINCT Bed_Name FROM Rooms WHERE Active_Flag = 1 ORDER BY Bed_Name ASC")
    End Sub

    '/*******************************************************************/
    '/*         SUBROUTINE NAME:     lstRooms_SelectedIndexChanged    	*/
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   02/17/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to populate the beds listbox  *;
    '/* with beds that have the room name equal to that of the item selected
    '/* in the rooms listbox. If a record in the database matches the   */
    '/* criteria, it is added to the beds listbox for the user to select*/
    '/* for deletion or to view what beds are in the room selected.     */
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/* ShowBeds                										*/
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/* sender - Holds the object the program is sending to the routine */
    '/* e   - Stores other arguments passed to the routine.             */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	lstRooms_SelectedIndexChanged  								    */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/* (None)                                                          */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*  BRH        02/17/21   Initial creation of the code-------------*/
    '/*******************************************************************/
    Private Sub lstRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRooms.SelectedIndexChanged
        lstBeds.Items.Clear()
        ShowBeds("SELECT DISTINCT Bed_Name FROM Rooms WHERE Room_ID = '" & lstRooms.SelectedItem & "' AND Active_Flag = 1 ORDER BY Bed_Name ASC")
    End Sub
End Class