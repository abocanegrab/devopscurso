#!/usr/bin/env groovy
// @Library(['shared-common@V2']) _

pipeline {
    agent any 
    environment {
        PROJECT_NAME = 'ProjectTest.sln'
        CONFIGURATION = 'RELEASE'
    }
    stages {
        stage('Setup parameters') {
            steps {
                script { 
                    properties([ 
                        parameters([
                            string(
                                name: 'ParentBuildVersion', 
                                trim: true
                            ),
                            string(
                                name: 'ParentBuildNumber', 
                                trim: true
                            ),
                            string(
                                name: 'DEPLOY_ENV', 
                                trim: true
                            )
                        ])
                    ])
                    currentBuild.displayName = "#${params.ParentBuildNumber}"
                    env.BUILD_VERSION = params.ParentBuildVersion
                    env.DEPLOY_ENV = params.DEPLOY_ENV 
                }
            }
        }
        // stage('Build') { 
        //     steps {
        //          sh '''dotnet restore ${PROJECT_NAME} 
        //          dotnet build ${PROJECT_NAME} --configuration ${CONFIGURATION}'''
        //     }
        // }
        // stage('Test') { 
        //     steps {
        //         sh 'dotnet test ${PROJECT_NAME}'
        //     }
        // }
        stage('Generate Docker Image') {
            steps {
                sh '''  docker login --username abocanegrab --password 2044r0n11
                        docker build -t abocanegrab/cursodevops . '''
            } 
        }
        stage('Push Docker Image') {
            steps {
                sh '''docker push abocanegrab/cursodevops '''
            } 
        }
    }
}