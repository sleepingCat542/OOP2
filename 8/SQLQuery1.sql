INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
SELECT '������ �.�', '24-01-1996', 'MP3523243', BulkColumn
from OpenRowSet(BULK N'H:\���\����\8\photo\1.jpg', SINGLE_BLOB ) AS ����;
INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
Select '�������� �.�.', '1991-04-24', 'MP5336632', BulkColumn
from OpenRowSet(BULK N'H:\���\����\8\photo\2.jpg', SINGLE_BLOB ) AS ����
INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
Select '����� �.�.', '1987-02-01', 'MP3242423', BulkColumn
from OpenRowSet(BULK N'H:\���\����\8\photo\3.jpg', SINGLE_BLOB ) AS ����
INSERT INTO Owner(Full_name, Birthday, Passport, Photo)
Select '�������� �. �.', '1993-07-08', 'MP5363662', BulkColumn
from OpenRowSet(BULK N'H:\���\����\8\photo\4.jpg', SINGLE_BLOB ) AS ����
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
Select '5767', '������� �����', '4', '24-01-2000', '�������� �.�.', '��', '���';
end;