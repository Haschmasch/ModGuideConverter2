# ModGuideConverter2

## Description
This project aims to convert the DHBW Module guides into the json format while also making them compliant to the european approach for micro credentials.
See https://eur-lex.europa.eu/legal-content/EN/TXT/HTML/?uri=CELEX:32022H0627(02)#ntc2-C_2022243EN.01001001-E0002 (especially Annex 1 & 2) for further information.

## The problems
1. There are multiple module guides
2. There are multiple DHBW faculties
3. There are multiple branch offices with different approaches to the module guides
4. The individual submodules of a module guide also need to be made compliant to the ESCO-Database.
   - This will involve a semi-automated process since the current state of the default modules by the DHBW is very different from a microcredential.

## The (theoretical) solution
We use a ASP.NET Core API as a backend that can parse and save module guides as json files on the server file-system using Newtonsoft.Json. 
LibGit2Sharp is used to save files in individual user folders (Branches) using Git-Worktrees. This also allows us to have a version-oriented approach in the backend while controlling the Git operations over the API.
We use a PostgreSQL-Database to store User data and additional information for the Git directories. The User-management is done using ASP.NET Core Identity. 

## Remarks
Please take a look at the open issues for missing features.
The wiki pages also give you further information regarding the individual parts of the project.
