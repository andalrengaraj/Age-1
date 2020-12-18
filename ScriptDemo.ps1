Param(
    [string]$SolutionName="SampleSolution",
    [string]$ProjetName="SampleProject"

)
#create a folder for solution
mkdir ./$SolutionName

#change directory into new solution folder
cd $SolutionName

#names for the various project types
$App=$ProjetName+"App"
$Lib=$ProjetName+"Lib"
$Test=$ProjetName+"Test"

#create folder for the various projects

mkdir ./$App
mkdir ./$Lib
mkdir ./$Test