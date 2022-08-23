#!/usr/bin/env groovy
// @Library(['shared-common@V2']) _

pipeline {
    agent any 
    stages {
        stage('Build') { 
            steps {
                 sh '''dotnet restore ProjectTest.sln 
                 dotnet build ProjectTest.sln --configuration RELEASE'''
//                 sh '''dotnet restore ProjectTest.sln 
// //                 dotnet build ProjectTest.sln --configuration RELEASE'''
            }
        }
        // stage('Test') { 
        //     steps {
        //         // 
        //     }
        // }
        // stage('Deploy') { 
        //     steps {
        //         // 
        //     }
        // }
    }
}

  // The Step of the build layed out.
//   stages {
//     stage('Setup parameters') {
//         steps {
//             script { 
//                 properties([ 
//                     parameters([
//                         string(
//                             name: 'ParentBuildVersion', 
//                             trim: true
//                         ),
//                         string(
//                             name: 'ParentBuildNumber', 
//                             trim: true
//                         ),
//                         string(
//                             name: 'DEPLOY_ENV', 
//                             trim: true
//                         )
//                     ])
//                 ])
//                 currentBuild.displayName = "#${params.ParentBuildNumber}"
//                 env.BUILD_VERSION = params.ParentBuildVersion
//                 env.DEPLOY_ENV = params.DEPLOY_ENV 
//             }
//         }
//     }
//    stage ('Restore and Build') {
//         steps {
//             sh '''dotnet restore ProjectTest.sln 
//                 dotnet build ProjectTest.sln --configuration RELEASE'''
//         }
//     }
    // stage ('Unit Tests') {
    //     steps {
    //         container('dotnet-core') {
    //             dir("${env.SOLUTION_PATH}/${env.UNIT_TEST_PROJECT}"){
    //                 // sh '''dotnet test ${UNIT_TEST_PROJECT}.csproj --logger:"console;verbosity=detailed" '''
    //             }
    //         }
    //     }
    // }
    // stage('Generate Docker Image') {
    //     steps {
    //         container('dotnet-core') {
    //             dir("${env.SOLUTION_PATH}"){
    //                 sh '''dotnet build ${SOLUTION_NAME}.sln -r win-x64 --configuration ${CONFIGURATION} '''
    //             }
    //         }
    //     } 
    // }
    // stage('Push Docker Image') {
    //     steps {
    //         script {
    //             env.DOCKER_IMAGE = "${DOCKER_URL}/${MICROSERVICE}:${BUILD_VERSION}"
    //         }
    //         dir("${env.SOLUTION_PATH}/OrdersService"){
    //             container('kaniko') {
    //                 sh "/kaniko/executor --cache=true --destination ${DOCKER_IMAGE} --context ./"
    //             }
    //         }
    //     }
    // }
        
	// 	stage ('Publish Artifacts To Octopus') {
	// 		steps { 
       
   	// 			script{
    //                     env.DBZIPFILE = "${PACKAGE_NAME}.Database.${BUILD_VERSION}.zip"
    //                     zip zipFile: "${DBZIPFILE}", dir: "${env.SOLUTION_PATH}/OrdersService/bin/Release/netcoreapp3.1/win-x64"   


    //                     env.LAMBDASZIPFILE = "Lambdas.${BUILD_VERSION}.zip"
    //                     zip zipFile: "${env.SOLUTION_PATH}/Infrastructure/${LAMBDASZIPFILE}", dir: "${env.SOLUTION_PATH}/Infrastructure/Lambdas"

    //                     env.ZIPFILE = "${PACKAGE_NAME}.Infrastructure.${BUILD_VERSION}.zip"
    //                     zip zipFile: "${ZIPFILE}", dir: "${env.SOLUTION_PATH}/Infrastructure"
	// 			}
	// 			container('octopus') {
	// 				sh ('''octo push --server ${OCTOPUS_URL}  --apiKey=${OCTOPUS_API_KEY} --package ${ZIPFILE}  --package ${DBZIPFILE}  --space LakeSuperiorSpace''')
	// 			}
    // 	    }
	// 	}   
 	// 	stage ('Create Release') {
  	// 		steps {
	// 			container('octopus') {
    //                 script{
    //                     echo "GIT_COMMIT is ${GIT_COMMIT}"
    //                     octopusPushBuildInformation toolId: 'Default', serverId: 'octopus-2.0', spaceId: 'LakeSuperiorSpace', commentParser: 'Jira', overwriteMode: 'FailIfExists', packageId: "${PACKAGE_NAME}.Database\n${PACKAGE_NAME}.Infrastructure", packageVersion: "${BUILD_VERSION}", verboseLogging: true, additionalArgs: '--debug', gitUrl: "${GIT_URL}", gitCommit: "${GIT_COMMIT}" 
    //                  }
	// 				sh ('''octo create-release --server ${OCTOPUS_URL}  --apiKey=${OCTOPUS_API_KEY} --project "${PROJECT}" --version ${BUILD_VERSION} --packageVersion ${BUILD_VERSION}  --deployTo ${DEPLOY_ENV} --space LakeSuperiorSpace''')
	// 			}
  	// 		}
	// 	}   
    // }
//}