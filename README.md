We have implemented the "Secure Session Management" tactic with the use case of a video rental website.

Using the asp.net MVC5 framework to accomplish this, we have:
1. Created 2 roles - Administrator, and User.
2. Implemented Authentication
3. Implemented Authorization checks for every request
4. Separated Movie data from user data by putting each into their own database

To test the application:
You can choose to create new users, as well as new movie entries if you wish, however by running
Update-Database in the package manager console, there will be sufficient test data seeded.
The credentials for the admin user is:
username: admin
password: 123456
Credentials for user user is:
username: john
password: 111111
Try logging in as the user 'john' and navigating to the 'classic movies' page from the link at the bottom
of the home page.
To test authorization, try editing or deleting a movie entry as the user 'john.'
Now, rent the movie.
Sign Out, and sign in as admin.
Navigate to the same movie list. Notice, that you can edit and delete movie entries. Select 'return' to
return the video that was rented out by 'john.' Notice that the 'available' column is now set back to
'yes.'
To test the anonymous user's privileges, sign out, and then navigate to movie list page. Try renting a movie.
