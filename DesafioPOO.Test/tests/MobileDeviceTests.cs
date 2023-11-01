namespace DesafioPOO.Test;
using DesafioPOO.Models;

public class MobileDeviceTests
{
    [Fact(DisplayName = "Test if Smartphone is abstract")]
    public void SmartphoneShouldBeAbstract()
    {
        // Arrange
        var smartphoneType = typeof(Smartphone);

        // Act & Assert
        Assert.True(smartphoneType.IsAbstract);
    }

    [Fact(DisplayName = "Test if Nokia inherits from Smartphone")]
    public void NokiaShouldInheritFromSmartphone()
    {
        // Arrange
        var nokiaType = typeof(Nokia);

        // Act & Assert
        Assert.True(typeof(Smartphone).IsAssignableFrom(nokiaType));
    }

    [Fact(DisplayName = "Test if Iphone inherits from Smartphone")]
    public void IphoneShouldInheritFromSmartphone()
    {
        // Arrange
        var iphoneType = typeof(Iphone);

        // Act & Assert
        Assert.True(typeof(Smartphone).IsAssignableFrom(iphoneType));
    }

    [Fact(DisplayName = "Test if Nokia overrides InstalarAplicativo method")]
    public void NokiaShouldOverrideInstallAppMethod()
    {
        // Arrange
        var nokia = new Nokia("123", "nokia", "imei", 32);
        string nomeApp = "AppName";

        // Create a StringWriter to capture console output
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        nokia.InstalarAplicativo(nomeApp);

        // Get the console output as a string
        string consoleOutput = stringWriter.ToString();

        // Assert
        Assert.Equal($"Instalando aplicativo {nomeApp} no Nokia\n", consoleOutput);
    }

    [Fact(DisplayName = "Test if Iphone overrides InstalarAplicativo method")]
    public void IphoneShouldOverrideInstallAppMethod()
    {
        // Arrange
        var iphone = new Iphone("123", "iphone 10", "imei", 64);
        string nomeApp = "AppName";

        // Create a StringWriter to capture console output
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        iphone.InstalarAplicativo(nomeApp);

        // Get the console output as a string
        string consoleOutput = stringWriter.ToString();

        // Assert
        Assert.Equal($"Instalando aplicativo {nomeApp} no Iphone\n", consoleOutput);
    }
}