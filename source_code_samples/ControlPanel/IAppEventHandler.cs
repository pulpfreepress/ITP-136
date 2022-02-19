using System;

public interface IAppEventHandler {
	
	void UniversalClickHandler(object sender, EventArgs e);
	
	void ConnectButtonHandler(object sender, EventArgs e);
	
	void MoveButtonHandler(object sender, EventArgs e);
	
}