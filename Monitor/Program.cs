using Monitor;

var monitor = new Screen("Samsung", "model", 21.5, "LED", true);
monitor.ScreenInfo();
monitor.ScreenSettings.ChangeBrightness(Operation.Plus);
monitor.ScreenOn();
monitor.ScreenSettings.ChangeBrightness(Operation.Plus);
monitor.ScreenSettings.ChangeBrightness(Operation.Minus);
monitor.ScreenSettings.ChangeLanguage();
monitor.ScreenSettings.RotateScreen();
monitor.ScreenSettings.RotateScreen();
monitor.ScreenSettings.ChangeContrast(Operation.Plus);
monitor.ScreenSettings.ChangeContrast(Operation.Plus);
monitor.ScreenSettings.ChangeContrast(Operation.Plus);
monitor.ScreenSettings.ChangeFrameRate(-50);
monitor.ScreenSettings.ChangeFrameRate(10000);
monitor.ScreenSettings.ChangeScreenResolution();
