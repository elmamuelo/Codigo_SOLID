using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new ExportHelper();
exportHelper.exportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");