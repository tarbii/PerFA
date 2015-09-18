# PerFA
######Personal Finance Accounting
WPF application for personal accounting implementing MVVM pattern and using Entity Framework to work with MS SQL database.

PerFA lets you authorize and calculate your expenses and income. 
You can add different types of transactions and analyze your turnover. 
Also it's possible to create shared transactions with other users by adding them to transaction.
Application has date, type and text filters so you can find specific transactions.

######How to run
To run this application you need to create database and check `connectionString` of Entity Framework in `App.comfig` file.

You can create database by building and deploying `PerFAdb` database project which is included into solution. 
It also contains postdeployment script `Script.PostDeployment2.sql` which will populate your database with test data.

Alternatively you can run `database.sql` script (specify where you want database files to be created) which also contains test data.

If you populated your database with test data you can use `user` as login and password to see application in work.
