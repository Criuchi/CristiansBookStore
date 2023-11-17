﻿// Author : Cristian Hernan Muller 
// Project: CristiansBookStore - Assignment 3  
// Date Created: 2023-10-24 1052 
// Date Finished: 2023-10-30 18:55


//            LOG              //

-- 2023-10-24

10:54
Created a new CristiansBookStore project and a README.txt file...

10:57
Creating a Github repository to connect it to the project...

10:58
Created the repository succesfully, now I will commit the changes documented and push them to move on to the next step...

11:05
Commented the sslPort in Properties/launchSettings.json line 7 to display my project without an error and proceeded to run the program...

11:08
The content was loaded and I attempted to create a new User in the "Register" section. After register I got an error related to not running Update-database I got an option to apply it.. After doing so, everything is working properly...

11:22
Tested out the breakpoints in the Controllers/HomeController.cs file lines 22 and 27. Everything worked accordingly so I'm moving the next step...

11:25
Checking https://bootswatch.com/ to select a theme for my Application. The selected theme is "Slate", now I will proceed to download the bootstrap.css...

11:28
Changed the name of the previous bootstrap file to boostrap-old.css and added the new bootstrap.css file to the folder...

11:39
Modified the content of the site.css file inside wwwroot/css and the Layout.cshtml inside Views/Shared...

-- 2023-10-25

18:35
Created a Dropdown Menu in the Navigation Bar...

19:10
Created 3 new projects and moved the "Data" folder to one of them and deleted the one inside CristiansBookStore...

-- 2023-10-26

18:35
Installed new NuGet packages and Updated the content in the new .DataAccess and .Models projects while deleting the data and models folders inside the main project...

-- 2023-10-27

16:22
Created a new Customer Area and moved certain files and folders from the Views folder in the CristiansBookStore project...

16:41
<<<<<<< HEAD
Created a new Admin Area and updated it's content...

16:57
Ran the program and debugged to make sure it works, everything is working correctly so I proceed to finish the part 1 of the project...

-- 2023-10-30

14:38
Deleted the 3 class library folders since they were not showing up in github...

14:40
Adding a new folder to see if it uploads to github this time...

17:40
Created a new project since the place the directory and solution in the same folder option was marked on....

17:46
Commented the sslPort to see the website...

18:07
Completed the selection of the theme in bootswatch and set it up...

18:08
Added 3 Class Libraries inside the Solution...

18:53
Completed the rest of the project. Testing it out...

18:58
The program is running and working. I proceed to finish the project and commit my last steps to github and pusg them. Starting all over again sure took me by suprise hahaha...


-- 2023-10-31

10:38
Proceeding to begin with the part 2 of this project...

10:48
Modified the content in appsettings.json and created a new migration called 20231031144750_AddDefaultIdentityMigration in the CristiansBooks.DataAccess project...

11:40
Created a Category.cs Class and then proceeded to update it to the database by initializing a new migration...

-- 2023-11-01

8:44
Created a new Folder named Repository with a IRepository folder inside, after that I created a new IRepository.cs Interface item and updated it's content...

9:05
Created a Repository.cs Class for the Repository folder and replaced it's content with the file provide in the Assignment 2 folder Repository.cs file from Blackboard... 

9:19
Created the CategoryRepository.cs Class and ICategoryRepository.cs Interface and updated it's content...

9:27
Updated the code in CategoryRepository.cs adding an Update method to update the code used in ICategoryRepository.cs...

9:43
Created an ISP_Call.cs Interface inside IRepository and updated it's content...

10:32
Updated the content in SP_Call.cs Class to make the connection to the database...

10:37
Created an IUnitOfWork.cs Inerface and updated it's content by adding references to the database. This project feels neverending >:^( ....

19:11
Created an UnitOfWork.cs Class and updated it's content. In addition, I tried to refer both class and interface in the Startup.cs File applying the using directory for both of them. I got
an error saying that UnitOfWork.cs was not being able to be called. After trying to find solutions by trial and error, I saw that the connection between class and interface is not done in the
class file. After doing it, the error was gone. I consider myself a genius at this point (not really Im just stressed out hahaha)...

19:34
Created a new CategoryController.cs Controller inside the Admin Area and updated it's content...

19:49
Created a new View in Admin named Index and updated it's content...

20:07
Linked the category controller to the dropdown navigation menu in the Layout.cshtml file in Views...

20:22
Created a category.js file and liked it to the Index.cshtml...

20:35
Modified the code in the Category Controller and created the Upsert.Razor View. After hours of working I decide to call it a day for now...

-- 2023-11-03

9:08
Created the _CreateAndBackToList and _EditAndBackToList Views to be used for the form located in Upsert.cshtml...

9:21
Modified the Upsert file in order to call the views that we have created before...

9:48
Moified the content of Index and Upsert to call the create and edit views. After finishing that and test it, I created a new POST method in the CategoryController.cs and added a Void Save in IUnitOfWork to make use of the Save method...

9:59
Commented the _db.SaveChanges() in CategoryRepository Line 30 since it was mentioned in the powerpoint slides in order to continue...

10:09
Added the HttpDelete API and created the Delete method for it...

10:22
Added the Delete function in Category.js...

10:24
With all the steps finished, I will proceed to run the program and see if everything is working properly

10:50
Modified the code since I was having an error that involved the return view of one of the methods in the controller. After modifying the code and running it again, the project is finished and I conclude to call it an end...


//         Part 3         //

-- 2023-11-14

18:07 
Created the Category.cs and CoverType.cs Classes inside CristianBooks.Models and modified it's content to create a new database for products...

18:25
Created the CoverTypeRepository and ICoverTypeRepository and modified the content in UnitOfWork and IUnitOfWork to reference the CoverType Repositories...

-- 2023-11-15

5:05
Added some code to make sure the upcoming migration runs properly to continue with the project...

5:07
Created the migration 20231115220628_AddCoverTypeToDb succesfully and updated the database with no errors found. Moving on to the next step of the assignment...

5:28
Created the CoverTypeController.cs and modified the code with the same structure as the CategoryController.cs while replacing all the content related to categories with CoverType instead...

6:22
Created the Index.cshtml and Upsert.cshtml files for CoverType folder inside Views and updated the code to make the new database display it's data...

6:31
Created a new CoverType.js file to make the calls to the API. After this, I proceed to test the program...

6:33
Everything is working perfectly so I proceed to move on to the next step...

6:39
Created a new Migration called 20231115220628_AddCoverTypeToDb and updated the database. No errors were found..

6:45
Created the Product.cs Class and updated its content...

6:56
Changed the validation for Title, Author and ISBN to required and created a new Migration called 20231115235053_AddValidationToProduct and updated the database...

8:35
Got an issue with the code which was preventing it from working, it seems to be related to the Product migrations so I will proceed to delete them and all the files related to product, and start
all over again tomorrow...

-- 2023-11-16

16:10
Managed to fix the database error by doing so many things I dont even remeber what I did. Moving on to the next project...

16:12
Created the migration for 20231116220814_addProductToDb succesfully...

16:55
Created the ProductRepository and IProductRepository files and modified UnitOfWork and IUnitOfWork and everything is working right now...

17:32
Created the ProductController and modfied it's content...

17:39
Created the ProductVM file in ViewModels and modified it's content. In addition, I have installed the Microsoft.AspNetCore.Mvc.ViewFeatures...

18:32
Created the index and upsert for Product and created the Product.js file. Proceeding to test the program...