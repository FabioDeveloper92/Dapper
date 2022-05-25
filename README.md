# Dapper
 
This tool belongs to the family of micro-ORMs.

## Intro

An ORM (Object Relational Mapping) allows you to use the entire database in the form of classes, interfaces etc. providing methods of working with it.

Dapper, being a micro orm, focuses only on the activity of working with tables.

## Pro

- Library is lightweight, high performance
- Reduces the DB access code
- It only focuses on mapping and not on other activities
- Work with any database

## How it work

It extends the IDbConnection interface (present in .NET), which allows you to create a connection with a SQL DB.

Every type of SQL DB has this connection, and dapper has methods to make it work, in this way we can work on any type of SQL DB.
