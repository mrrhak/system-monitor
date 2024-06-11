<h1 align="center">☘️ System Monitor ☘️</h1>

<div align="center">

[![Developer](https://img.shields.io/badge/Developed_by-Mrr_Hak-blue.svg?logo=devdotto)](https://mrrhak.com)
[![.Net](https://img.shields.io/badge/Using-.Net-purple.svg?logo=dotnet)](https://dotnet.microsoft.com/)
[![Swagger](https://img.shields.io/badge/Using-Swagger-green.svg?logo=swagger)](https://swagger.io)
[![OpenTelemetry](https://img.shields.io/badge/Using-OpenTelemetry-yellow.svg?logo=opentelemetry)](https://opentelemetry.io)
[![Prometheus](https://img.shields.io/badge/Using-Prometheus-orange.svg?logo=prometheus)](https://prometheus.io)
[![Grafana](https://img.shields.io/badge/Using-Grafana-red.svg?logo=grafana)](https://grafana.com)
[![Docker](https://img.shields.io/badge/Using-Docker-blue.svg?logo=docker)](https://www.docker.com)
</div>

The "System Monitor" is an advanced and scalable monitoring solution designed to provide in-depth insights into the performance and health of your applications and infrastructure. By integrating OpenTelemetry, Prometheus, and Jaeger, this system offers comprehensive observability, enabling proactive monitoring, rapid troubleshooting, and detailed performance analysis.


## System Monitor Distribution
- [x] **Health Check** Endpoint
- [x] **Metrics** to Prometheus with Grafana
- [ ] **Tracing** with Jaeger
- [ ] **Logs**

## Key Features:
#### 1. Unified Observability:
- **OpenTelemetry Integration**: Collect traces, metrics, and logs from various sources in a standardized format. OpenTelemetry ensures consistent data collection, simplifying the integration and analysis of telemetry data across diverse systems.
- **Distributed Tracing**: With OpenTelemetry and Jaeger, gain detailed visibility into application performance and dependencies. Trace requests as they propagate through microservices to identify latency bottlenecks and optimize the user experience.

#### 2. Powerful Metrics Collection and Storage:
- **Prometheus Integration**: Utilize Prometheus for efficient metrics collection and storage. With its robust time-series database and powerful query language, Prometheus enables real-time monitoring and alerting.
- **Custom Metrics**: Define and collect custom metrics to suit your specific monitoring needs. Track application-specific events, resource utilization, and performance indicators to get a comprehensive view of system health.

#### 3. Advanced Tracing and Visualization:
- **Jaeger Integration**: Use Jaeger for end-to-end distributed tracing. Visualize request flows and performance data across microservices, helping you understand system behavior and identify performance issues.
- **Root Cause Analysis**: Correlate traces with metrics and logs to gain a holistic view of incidents. Perform deep dives into specific events to quickly identify and resolve root causes.

#### 4. Real-Time Monitoring and Alerting:
- **Dashboards and Visualization**: Use Grafana or similar tools to create intuitive and interactive dashboards. Visualize key performance indicators (KPIs) and monitor system health in real-time with customizable graphs and charts.
- **Alerting and Notifications**: Set up alerting rules to notify you of critical issues before they impact users. Integrate with various notification channels like email, Slack, or PagerDuty to ensure timely response to incidents.

#### 5. Scalable and Flexible Architecture:
- **Microservices Friendly**: Designed to work seamlessly in microservices environments. Easily scale monitoring capabilities as your infrastructure grows.
- **Interoperability**: Compatible with various cloud providers, container orchestration platforms (like Kubernetes), and traditional server environments. Ensure consistent monitoring across hybrid and multi-cloud setups.


### Benefits
- **Proactive Monitoring**: Detect and address issues before they impact end-users, reducing downtime and enhancing user satisfaction.
- **Enhanced Visibility**: Achieve comprehensive visibility into the performance and health of your entire system, from infrastructure to application level.
- **Efficient Troubleshooting**: Accelerate incident resolution with precise and contextual insights, minimizing the mean time to resolution (MTTR).
- **Performance Optimization**: Use detailed telemetry data to optimize application performance, identify resource inefficiencies, and make informed decisions to enhance system reliability and efficiency.
- **Scalability**: Adapt to growing and evolving environments without compromising on monitoring capabilities or performance.

The System Monitor, leveraging OpenTelemetry, Prometheus, and Jaeger, is your ultimate solution for achieving unparalleled observability, ensuring the optimal performance of your applications and infrastructure, and maintaining a resilient and high-performing system environment.

## Start Application

```bash
docker-compose up -d
```

## Stop Application

```bash
docker-compose down
```

## .Net Application
- Swagger: http://localhost:8000/swagger
- Metrics: http://localhost:8000/metrics
- Health Check: http://localhost:8000/health

## Prometheus Application (Metrics Collector)
- Dashboard: http://localhost:9090


##  Grafana Application (Metrics Viewer)
- Dashboard: http://localhost:3000
- Recommended Dashboard ID: `19925`, `17706`, `19924`

---
<div align="center">

[![Developer](https://img.shields.io/badge/Developed_by-Mrr_Hak-blue.svg?logo=devdotto)](https://mrrhak.com)
</div>