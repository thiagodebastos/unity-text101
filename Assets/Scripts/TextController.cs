using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom };
	private States myState;

	// Use this for initialization
	void Start()
	{
		myState = States.cell;
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log(myState);
		if (myState == States.cell) state_cell();
		else if (myState == States.mirror) state_mirror();
		else if (myState == States.cell_mirror) state_cell_mirror();
		else if (myState == States.sheets_0) state_sheets_0();
		else if (myState == States.sheets_1) state_sheets_1();
		else if (myState == States.lock_0) state_lock_0();
		else if (myState == States.lock_1) state_lock_1();
		else if (myState == States.freedom) state_freedom();
	}

	void state_cell()
	{
		text.text = "You are in a prison cell, and you want to escape. There are " +
		"some dirty sheets on the bed, a mirror on the wall, and the door " +
		"is locked from the outside.\n\n" +
		"Press S to view Sheets, M to view Mirror and L to view Lock";

		if (Input.GetKeyDown(KeyCode.S)) myState = States.sheets_0;
		else if (Input.GetKeyDown(KeyCode.M)) myState = States.mirror;
		else if (Input.GetKeyDown(KeyCode.L)) myState = States.lock_0;
	}

	void state_mirror()
	{
		text.text = "You are so sexy. You sexy beast. Your bed sheets are dirt because you are a wild beast.\n\n" +
		"Press R to return to pacing your cell - keeping in mind how sexy you are.\n" +
		"Press T to take the mirror.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell;
		if (Input.GetKeyDown(KeyCode.T)) myState = States.cell_mirror;
	}

	void state_cell_mirror()
	{
		text.text = "Back in your cell. Armed with a mirror you are ready to derealise this situation.\n\n" +
		"Press R to return to pacing your cell.\n" +
		"Press S to view the Sheets again.\n" +
		"Press L to have a crack at the lock.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell;
		if (Input.GetKeyDown(KeyCode.S)) myState = States.sheets_1;
		if (Input.GetKeyDown(KeyCode.L)) myState = States.lock_1;
	}
	void state_sheets_0()
	{
		text.text = "For 19 years you've slept on these sheets. They are so dirty.\n" +
		"How did they get so dirty?\n\n" +
		"Press R to return to pacing your cell.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell;
	}
	void state_sheets_1()
	{
		text.text = "Ready to self-derealise, you look down at your bed once more " +
		"remembering what happened here. The indignation...\n\n" +
		"Press R to return to pacing your cell.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell_mirror;
	}

	void state_lock_0()
	{
		text.text = "You look down at the lock. It's a colon-scanner. A result of Trump's recent security bill.\n" +
		"It is a good implementation. It's true.\n" +
		"If only there was a non-sensical way to bypass the scanner...\n\n" +
		"Press R to return to pacing your cell - keeping in mind how sexy you are.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell;
	}

	void state_lock_1()
	{
		text.text = "Ready with the sex-imbued mirror in hand, you prepare yourself to crack the colon-scanner.\n\n" +
		"Press O to attempt to bypass the colon scanner with the mirror in your hand.\n" +
		"Press R to return to pacing your cell.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell_mirror;
		if (Input.GetKeyDown(KeyCode.O)) myState = States.freedom;
	}

	void state_freedom()
	{
		text.text = "The cell door opens. A testament to your superior sexiness." +
		"Out of your cell, in the still of the night, where will you go?\n\n" +
		"Press P to Play again.";

		if (Input.GetKeyDown(KeyCode.R)) myState = States.cell;
	}
}
