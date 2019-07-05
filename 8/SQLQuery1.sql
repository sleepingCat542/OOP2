INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
SELECT 'Егоров В.В', '24-01-1996', 'MP3523243', BulkColumn
from OpenRowSet(BULK N'H:\ООП\Лабы\8\photo\1.jpg', SINGLE_BLOB ) AS Файл;
INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
Select 'Савушкин Е.Е.', '1991-04-24', 'MP5336632', BulkColumn
from OpenRowSet(BULK N'H:\ООП\Лабы\8\photo\2.jpg', SINGLE_BLOB ) AS Файл
INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
Select 'Машов В.И.', '1987-02-01', 'MP3242423', BulkColumn
from OpenRowSet(BULK N'H:\ООП\Лабы\8\photo\3.jpg', SINGLE_BLOB ) AS Файл
INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
Select 'Метёлкина М. В.', '1993-07-08', 'MP5363662', BulkColumn
from OpenRowSet(BULK N'H:\ООП\Лабы\8\photo\4.jpg', SINGLE_BLOB ) AS Файл
Select * from Owner

use OOP
go
create procedure counts
as
begin
declare @k int=(select count(*) from Owner);
select @k;
end;


go
create procedure inser
as
begin
INSERT INTO Account(Number, Type, Balance, OpeningDate, Owner, Banking, Sms)
Select '5767', 'Срочный вклад', '4', '24-01-2000', 'Метёлкина М.В.', 'да', 'нет';
end;