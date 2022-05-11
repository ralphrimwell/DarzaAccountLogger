# DarzaAccountLogger
Darza's Dominion account/auth token logger

DISCLAIMER I DO NOT CLAIM ANY RESPONSIBILITY FOR WHAT YOU DO WITH THIS SOFTWARE, THIS IS SIMPLY DOCUMENTATION FOR A POSSIBLE VULNERABILITY

After reading the source code in the darza beta build i noticed that they were parsing a .dat file into a game settings class. I tried moving this settings.dat
to a folder and noticed it has just logged me out to prove that i had found the authentication token.

If you are able to run this program on a victims computer you will be able to gain access to their Darza account.

The settings.dat file is also encrypted with what i assume to be the RSA algorithm, however i havent checked.
