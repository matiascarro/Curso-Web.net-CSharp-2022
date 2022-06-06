// See https://aka.ms/new-console-template for more information

using CsvTools;

CsvRow csvRow = new CsvRow();
csvRow.AgregarCampo("Nombre", "Matias");
csvRow.AgregarCampo("Edad", "35");
csvRow.AgregarCampo("Dni", "1234567");
CsvRow csvRow2 = new CsvRow();
csvRow.AgregarCampo("Nombre", "Patricio");
csvRow.AgregarCampo("Edad", "25");
csvRow.AgregarCampo("Dni", "123456723");

Campo c = new Campo("Dni", "1234567");
Campo c2 = new Campo("Dni", "123456723");

Campo campoDni = csvRow["Dni"];

Campo campoPosicion = csvRow[0];

Console.WriteLine(csvRow.ImprimirRegistro());

CsvIndexado csv = new CsvIndexado();
csv[c] = csvRow;
csv[c2] = csvRow2;

Console.WriteLine(csv[c].ImprimirRegistro());
Console.WriteLine(csv[c2].ImprimirRegistro());


