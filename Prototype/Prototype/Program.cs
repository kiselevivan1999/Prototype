using Prototype.Entities;
using Prototype.Enums;

//Создаем начальные объекты
var contractor = new Contractor
{
    Id = Guid.NewGuid(),
    Name = "ООО Тест",
    INN = "1234567890",
    KPP = "123456789",
    Address = "г. Москва"
};

var contract = new Contract
{
    Id = Guid.NewGuid(),
    Number = "ДОГ-2025-001",
    CreateDate = DateTime.UtcNow.AddDays(-30),
    StartDate = DateTime.UtcNow.AddDays(-30),
    Contractor = contractor,
    ContractorId = contractor.Id
};

var originalSpec = new SpecContract
{
    Id = Guid.NewGuid(),
    Number = "СПЕЦ-001",
    StartDate = DateTime.UtcNow.AddDays(-30),
    Services = new List<Service>
            {
                new Service
                {
                    Id = Guid.NewGuid(),
                    Name = "Аренда сервера",
                    Payment = 10000,
                    ServiceType = ServiceTypeEnum.SERV,
                    ServiceDetalies = new ServiceDetalies
                    {
                        QuentityCpu = 4,
                        QuentityRam = 16,
                        QuentityHdd = 500
                    }
                }
            }
};

contract.SpecContracts.Add(originalSpec);
originalSpec.Contract = contract;

//Вывожу начальные данные
contract.ConsoleWriteLine();

//Копирую спецификацию через IMyCloneable
var specCopyMy = originalSpec.MyClone();
contract.SpecContracts.Add(specCopyMy);
Console.WriteLine($"\n Копируем спецификацию +++++++++++++++++++++");
contract.ConsoleWriteLine();

//Копирую спецификацию через ICloneable
var specCopy = (SpecContract)originalSpec.Clone();
contract.SpecContracts.Add(specCopy);
Console.WriteLine($"\n Копируем спецификацию +++++++++++++++++++++");
contract.ConsoleWriteLine();