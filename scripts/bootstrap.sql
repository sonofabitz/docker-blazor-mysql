create database MusicStoreDB;

use MusicStoreDB;

create table 
    album (
        id int not null primary key auto_increment,
        name char(25),
        artistname char(30),
        price decimal(2),
        genre char(30)
    );
    
insert into 
    album 
        (name, artistname, price, genre) 
    values
        ('One', 'AKON', 15, 'pop'),
        ('MyLove', 'AKON', 15, 'pop'),
        ('destiny', 'AKON', 15, 'pop'),
        ('MySongs', 'John', 15, 'pop');

