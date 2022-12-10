Project: PrafullaBookStore
Date: 2022-10-28
Startrd At 12:10 PM

using HTTP
Individual Account authorization
Enable Razor runtime compilation

----------------12:15PM-----------------

"sslPort": 44369 //comment it for security purpose.
options => options.SignIn.RequireConfirmedAccount = true //remove it from Startup.cs

-----------------12:30PM-----------------

Create Git repository name PrafullaBookStore
follow the given instuctions..
start debugging ..
select IIS Express for debug.
Debugging successful

---------------1:00PM------------------

Go to Bootswatch.com
selected Darkly theme for project
downloaded bootstrap.css
relaceed it with existing bootstrap.css in wwwroot>lib>bootstrap>dist>css
start debugging ..
Debugging successful but got warning related to bootstrap.css
don't get any design.

----------------1:19PM----------------

go to Views>Shared>_Layout.cshtml and change file from bootstrap.min.css to bootstrap.css
commit all changes to Git repository
start debugging ..
Debugging successful
get new design which was downloaded

-----------------1:23PM-------------

go back to _Layout.cshtml and comment out old file bootstrap.min.css.
and add bootstrap.css in its place
commit changes in git

-------------Day:03-11-2022-------------
---------------10:00PM---------------
remove text-dark from _Layout.cshtml
and add additinal properties in footer class in _Layout.cshtml

---------------10:05PM--------------
remove text-dark from _LoginPartial.cshtml file.
review the project to see changes.

-------------------11:18PM-------------
add additional stylesheets in _Layout.cshtml file.

-------------------11:34PM--------------
add additional scripts in _Layout.cshtml file.

---------------------11:49PM--------------
add dropdown menu in _Layout.cshtml file.
debug program to see changes
dropdown is working.

----------------12:10AM--------------
Commit changes in github

-------------------12:31AM-------------
create 3 new projects in existing project
copy Data folder to PrafullaBooks.DataAccess Project and delete original folder.
add packages
delete migrations folder

---------------------12:47AM---------------
Modify Namespace in ApplicationDbContext.cs
deleted all class1.cs files from 3 projects.

-----------------------12:51AM------------
Move Models from PrafullaBookstore to PrafullaBooks.Models

-----------------12:56AM----------------
Add references for .DataAccess and .Models for PrafullaBookStore
Rename Foldername to Models to ViewModels in PrafullaBooks.Model project.
Change in namespace in Prafulla Books.Model project.

----------------------01:07AM------------
made modification in Startup.cs .
got multiple errors.
trying to resolve idividual errors.
change defult reference in Error.cshtml file.

----------------------01:11AM--------------
solve all errors.
run program
got the proper view of in browser.

-------------------01:12AM---------------
in PrafullaBooks.Utility project create a class name SD.cs

---------------------01:23AM------------
Add modifications according to given instruction.
make changes in startup.cs file.
move folders.
change namespace etc...

--------------01:26AM--------------------
Run Application.
lost Background and got plain website.

---------------01:31AM-----------------
Copy _ViewImports.cshtml, _ViewStart.cshtml files in Customer Folder
Modify _ViewStart.cshtml path .
run application.
Got the design back.

----------------01:40AM-----------------
Add Admin Area in Area Folder
Delete Data, Models Folers from Admin
Delete Controller folder from PrafullBookStore.

-------------------01:47AM-----------------
Commit all changes to git.
PrafullaBookStore Project Part-1 Complete!!!

-----------------04-11-2022------------
can not debug project
create new project
delete repository
create new repository
but not working
try again..
again...
not working.
----------------06-11-2022---------------
create new project from scratch
got so many errors for packages
can not rebuild project
tried.
---------------07-11-2022------------
just delete all repository related to project
upload all file on onedrive
create whole new git repository.

----------------11-11-2022--------------

---------------------01:12PM--------------
build project
checked there are no errors.
build sucessfull

------------------01:13PM----------------
go to appsettings.json change database name

--------------------01:20PM----------------
add migration
build succeeded
but not properlly added migration
change default project to PrafullaBooks.DataAccess

------------------01:24PM-------------

add migration file
build succeeded
properlly added migration in dataAccess
name:20221111205127_AddDefaultIdentityMigration

-------------------01:32PM-----------------

update datebase
build done

---------------------01:35PM---------------

checked SQL Server Object

---------------------01:40PM---------------

check for errors .
no errors.
run sucessfully.

------------------03:56PM-----------------

create Category.cs im models project.
modify class file.
add migration for AddCategoryToDb

---------------04:12PM----------------
update database
re run add migration for AddCategoryToDb
got duplication
remove migration for AddCategoryToDb
re run add migration for AddCategoryToDb
success.
update database.
found category table.

------------------04:17PM----------------
Commit on git.

---------------4:37PM---------------
add folder name Repository
then add folder name IRepository
add interface name Irepository.cs
modify it.

-------------4:45PM---------------
create a class in Repository name Repository.cs
add using statements.
fixed errors using potential fixes

----------------4:57PM-----------------
make changes in Repository.cs according to given file.

-----------------5:21PM---------------
created interface file  name ICategoryRepository.cs
and created a class file name CategoryRepository.cs

made modification in CategoryRepository.cs
also modify ICategoryRepository.cs interface

----------------5:24PM----------------
review error in CategoryRepository.cs
try to fix errors

----------------5:25PM-----------
build and fixed errors
commit on git
----------------6:26PM-------------
created interface file  name ISP_Call.cs
and created a class file name SP_Call.cs

-----------------6:28PM--------------
made modification in SP_Call.cs
also modify ISP_Call.cs interface according to given instructions

----------------6:30PM----------------
created interface file  name UnitOfWork.cs
and created a class file name UnitOfWork.cs

------------------12-11-2022-------------

----------------------09:55PM----------------------
made modification in UnitOfWork.cs
also modify UnitOfWork.cs interface according to given instructions

add using statement in Startup.cs
Add services statement in Startup.cs

fixing errors in Project.

------------------13-11-2022----------------------

----------------01:06PM-----------------
add new controller in area/admin folder
name:CategoryController.cs
get some errors.
fixing error with adding using statement.

--------------------01:24PM--------------
create new folder name Category
add razor page and modify.

-------------------01:34PM----------------
add category link in _Layout.cshtml
make changes in _Layout.cshtml for navigation bar

------------------01:50PM-----------------
modify index.cshtml file for category section

-------------------02:01PM----------------
delete modify code for category section
add js file in wwwroot/js folder name category.js
save changes and run project

--------------------02:10PM-------------
modify CategoryController.cs for Upsert method
add razor file called Upsert.cshtml and modify it.

-----------------------03:18PM----------------
create _CreateAndBackToListButton.cshtml razor file add content.
create _EditAndBackToListButton.cshtml razor file add content.

-------------------------04:30PM---------------
could not able to commit changes in git.
try
try
again trying
failed to do

-----------------------05:12PM--------------
trying to commit in git through terminal
it worked.
commit all the changes in git.

----------------------05:17PM----------------
modify file: Upsert.cshtml
add asp-ation to index.cshtml
add Upsert POST Method in CategoryController.cs
get some error in project
tring to solve that.

-----------------05:20PM--------------
checking the code where i am getting errors.
tring to resolve those.

-----------------05:31PM--------------------
resolve all errors.
add API call in CategoryController.cs

----------------05:34PM----------------
adding delete method in category.cs file
and adding delete functionality & url function. in category.cs file

----------------05:43PM------------------
all coding is completed according to instructions.
now checking for any errors.

----------------05:48PM--------------------
no error found.
project is running.

---------------------9:45PM------------------
finally commit all changes on git.
project part-2 completed.

-------------------------24-11-2022--------------------

-------------------------9:38PM-----------------------
Create a CoverType.cs file in model folder
add CoverType model 
Add ID and Name method in file.

--------------------------9:40PM----------------------
CoverTypeRepository.cs class
and ICoverTypeRepository.cs Interface file.

--------------------------25-11-2022-----------------------

---------------------9:03AM-----------------------
undo everything for CoverType.
and restarted all fresh for that.

created CoverType.cs file.
add migration for that.
20221125140227_AddCoverTypeToDb.cs is created.

-------------------------9:19AM-----------------
Created CoverTypeRepository.cs class
and ICoverTypeRepository.cs Interface file.

and modify it.

----------------------9:28AM-----------------
add CoverTypeRepository.cs to the IUnitOfWork and UnitOfWork files.
modify IUnitOfWork and UnitOfWork files.

---------------------9:46AM----------------------
created CoverTypeController.cs file.
modify it.

Add CoverType folder in View folder
add index view file in that.
and modify it.
and modify it.

--------------------9:51AM----------------
add CoverType in navigation in _Layout.cshtml file.
it shows in browser.

------------------9:57AM------------------
created coverType.js file.
modify it.

------------------10:21AM-----------------
added insert.cshtml
and Upset.cshtml file in CoverType folder
and modify it.

------------------10:30AM--------------
stared Product part.
Create Product.cs class in models.
modify it.

--------------------10:46AM----------------
Adding product reference in ApplicationDbContext.cs
add migration for product.
name:20221125154908_AddProductToDb
update the database


----------------------10:50AM------------------
see the product table in SOE review

----------------------11:18AM---------------
add migration fo addValidationToProfuct
name:20221125160038_AddValidationToProduct

created IProductRepository and ProfuctRepository.
and modify it.
add product in IUnitOfWork and UnitOfWork.

--------------------11:30AM-------------------
Add ProductController
modify it.

add ProductMV.cs
and modify it.

------------------04-12-2022-------------------------
-------------------05:02 PM----------------
modify CategoryController.cs

------------------05:08PM------------------
modify CoverTypeController.cs

----------------05:11PM---------------
modify ProductController.cs

---------------05:46PM-----------
update README.

-------------11:27PM--------------
update Starup.cs
commit all changes in Git.
----------------05-12-2022-----------------
---------------------12:28AM------------------
update HomeController.cs
commit changes

remove old update from CoverTypeController.cs
commit changes
---------------------2022-12-09--------------------
-----------------------12:10PM-------------------
try to resolve git problem
i am not able to upload all four folders of project in git.
still trying.
try......
try....
delete old repositoty .
making new one.
--------------------3:10PM------------------
making multiple repository and try to change path and name of repository.
still not working.
--------------------4:30PM------------------
attemt multiple times.
tried.
:(
--------------------4:55PM------------------
submitted another repository name: PrafullaBooks
it have only 3folders.
does not have main folder.
