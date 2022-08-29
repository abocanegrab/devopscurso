pipeline {
    agent any 
    // environment {
    //     PROJECT = "Devops Curso"
    // }
    // options {
    //     buildDiscarder(logRotator(numToKeepStr: '25')) // We need to Keep track of these builds
    // }

    stages {
        stage('Select Version'){
            steps{
                script{
                    switch(GIT_BRANCH) {
                        case "develop":
                            env.BUILD_VERSION = "1.0.${BUILD_NUMBER}-dev"
                            env.DEPLOY_ENV = "Development"
                            env.CREATE_RELEASE = false  
                            break
                        case "release":
                            env.BUILD_VERSION = "1.0.${BUILD_NUMBER}-uat"
                            env.DEPLOY_ENV = "UAT"
                            env.CREATE_RELEASE = false   
                            break
                        case "master":
                            env.BUILD_VERSION = "1.0.${BUILD_NUMBER}-master"
                            env.DEPLOY_ENV = "Production"        
                            env.CREATE_RELEASE = true        
                            break
                        default:
                            env.BUILD_VERSION = ""
                            env.DEPLOY_ENV = ""
                            env.CREATE_RELEASE = false  
                    }
                    println(env.BUILD_VERSION)
                    println(env.DEPLOY_ENV)
                    println( env.CREATE_RELEASE)
                }
            }
        }
        stage ('Inicia Construccion segun check-in') {
            parallel {
                stage('Inicia Devops Microservicio'){

                    when {  changeset '**/MicroService/**'  }
                    steps {
                        build job: "CursoDevOps/CI-ServiceNet60-DEVMultiBranch/${env.BRANCH_NAME}",  propagate: true, wait: true, parameters: [[$class: 'StringParameterValue', name: 'ParentBuildVersion', value: String.valueOf(BUILD_VERSION)], [$class: 'StringParameterValue', name: 'ParentBuildNumber', value: String.valueOf(BUILD_NUMBER)], [$class: 'StringParameterValue', name: 'DEPLOY_ENV', value: String.valueOf(env.DEPLOY_ENV)]]

                    }
                }
            }
        }
   }
}