// See https://aka.ms/new-console-template for more information

using Builder.Classes;


var garage = new Garage();

var miniBuilder = new MiniBuilder();
garage.Construct(miniBuilder);
garage.Show();

var bmwBuilder = new BMWBuilder();
garage.Construct(bmwBuilder);
garage.Show();