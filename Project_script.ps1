Param(
    [string]$SolutionName="SampleSolution",
    [string]$ProjectName="SampleProject",
    [string]$ClassName="SampleClass"

)
#create a folder for the solution
mkdir ./$SolutionName

#change Directory into the new solution folder 
cd $SolutionName

#solution folder name
$sln=$SolutionName+"sln"

#solution file name
$slnFile=$sln+".sln"

#create a new dotnet solution

dotnet new sln -n $sln

#Names for the various projects and files 

$App=$ProjetName+"App"
$AppProj="./"+$App+"/"+"$App"+".csproj"
$Lib=$ProjectName+"Lib"
$LibProj="./"+$Lib+"/"+"$Lib"+".csproj"

#create new dotnet console app
dotnet new console -n $App

#create new dotnet class library
dotnet new classLib -n $Lib

#create new dotnet mstest project
dotnet new mstest -n $Test

#create new dotnet gitignore file

dotnet new gitignore

#add the three project to the solution

dotnet sln $slnFile add $AppProj

dotnet sln $slnFile add $LibProj

dotnet sln $slnFile add $TestProj

#rename
rename -item "Sampleclass"=new "SampleClass_1"

#add library project as refernce to app and test projects

dotnet add $AppProj refernce $LibProj

dotnet add $TestProj refernce $LibProj

git init

git add .

git commit -m " add  all"

#Open the solution directory in vs code
code .
