# MigrationDetection
Detection of VM Migration on Public Cloud

This project is a WCF service which you can host on your Virtual Machine to identify if there the machine is migrating to new location.

1. Build the project and host it on IIS.
  For example, this service is hosted on http://localhost:58975/Detect.svc

2. Add the ServiceReference to your client module giving the URL of the hosted WCF.

  Following are the modules which you can call from client module-
  1. setLandMark("google.com", "yahoo.com", "facebook.com") - Sets the landmark for which you want your service to ping.
  2. setPingCounter(counter) - pings the landmarks for counter no. of times.
  3. setThreshold(threshold factor) - sets the threshold factor.
  4. calculateAvgLatency() - Calculates the average latencies.
  5. calculateMinThreshold() - Caluclates the minimum threshold latency
  6. calculateMaxThreshold() - Caluclate the maximum threshold latency
