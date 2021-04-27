use MyMagazin2
go 

alter table Users add IdDeletid bit default 0;
alter table UserOfClient add IdDeletid bit default 0;
alter table Users add IdDeletid bit default 0;
alter table Client add IdDeletid bit default 0;
alter table ListOfProductsInOrder add IdDeletid bit default 0;
alter table Products add IdDeletid bit default 0;
alter table Orders add IdDeletid bit default 0;
