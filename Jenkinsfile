pipeline {
    agent any

    environment {
        DOTNET_CLI_TELEMETRY_OPTOUT = '1'
        DOTNET_NOLOGO = '1'
    }

    stages {
        stage('Restore') {
            steps { sh 'dotnet restore learn_cicd.slnx' }
        }
        stage('Build') {
            steps { sh 'dotnet build learn_cicd.slnx -c Release --no-restore' }
        }
        stage('Test') {
            steps { sh 'dotnet test learn_cicd.slnx -c Release' }
        }
        stage('Publish') {
            steps { sh 'dotnet publish learn_cicd/learn_cicd.csproj -c Release -o publish' }
        }
    }
}
