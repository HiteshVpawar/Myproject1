"use client";

import { Zap } from "lucide-react";

interface DataPoint {
  x: number;
  runningLoadDemand: number;
  availableCapacity: number;
}

export default function LoadDemandCapacityWidget() {
  // Sample data matching the image description
  const data: DataPoint[] = [
    { x: 0, runningLoadDemand: 1.8, availableCapacity: 2.5 },
    { x: 1, runningLoadDemand: 1.4, availableCapacity: 2.5 },
    { x: 2, runningLoadDemand: 1.6, availableCapacity: 2.5 },
    { x: 3, runningLoadDemand: 2.0, availableCapacity: 2.5 },
    { x: 4, runningLoadDemand: 3.0, availableCapacity: 2.5 },
    { x: 5, runningLoadDemand: 2.2, availableCapacity: 2.5 },
    { x: 6, runningLoadDemand: 2.5, availableCapacity: 2.5 },
    { x: 7, runningLoadDemand: 3.2, availableCapacity: 2.5 },
    { x: 8, runningLoadDemand: 3.5, availableCapacity: 2.5 },
  ];

  // Chart dimensions
  const width = 380;
  const height = 400;
  const padding = { top: 60, right: 40, bottom: 50, left: 50 };
  const chartWidth = width - padding.left - padding.right;
  const chartHeight = height - padding.top - padding.bottom;

  // Y-axis scale (0 to 5K)
  const maxY = 5;
  const yScale = (value: number) => {
    return chartHeight - (value / maxY) * chartHeight;
  };

  // X-axis scale
  const maxX = Math.max(...data.map((d) => d.x));
  const xScale = (value: number) => {
    return (value / maxX) * chartWidth;
  };

  // Generate path for running load demand (blue line)
  const runningLoadPath = data
    .map(
      (point, index) =>
        `${index === 0 ? "M" : "L"} ${xScale(point.x) + padding.left} ${
          yScale(point.runningLoadDemand) + padding.top
        }`
    )
    .join(" ");

  // Generate path for available capacity (green horizontal line)
  const capacityY = yScale(data[0].availableCapacity) + padding.top;
  const capacityPath = `M ${padding.left} ${capacityY} L ${
    padding.left + chartWidth
  } ${capacityY}`;

  // Generate area under running load demand
  const areaPath = [
    `M ${xScale(data[0].x) + padding.left} ${yScale(0) + padding.top}`,
    ...data.map(
      (point) =>
        `L ${xScale(point.x) + padding.left} ${
          yScale(point.runningLoadDemand) + padding.top
        }`
    ),
    `L ${xScale(data[data.length - 1].x) + padding.left} ${
      yScale(0) + padding.top
    }`,
    "Z",
  ].join(" ");

  return (
    <div
      className="relative bg-slate-900 rounded-lg border-2 border-blue-500"
      style={{ width: `${width}px`, height: `${height}px` }}
    >
      {/* Header with icon and title */}
      <div className="flex items-center px-4 pt-4 pb-2">
        <div className="w-10 h-10 rounded-lg bg-gradient-to-br from-purple-500 to-purple-700 flex items-center justify-center mr-3 flex-shrink-0">
          <div className="relative w-6 h-6">
            <Zap className="w-3.5 h-3.5 text-white absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 z-10" />
            <svg
              className="absolute inset-0 text-white"
              viewBox="0 0 24 24"
              fill="none"
              stroke="currentColor"
              strokeWidth="2"
              strokeLinecap="round"
            >
              <path d="M12 2a10 10 0 0 1 10 10" />
              <path d="M22 12a10 10 0 0 1-10 10" />
            </svg>
          </div>
        </div>
        <h3 className="text-white text-sm font-medium">
          Running Load Demand vs Available Capacity
        </h3>
      </div>

      {/* Chart */}
      <div className="px-2 pb-2">
        <svg width={width} height={height} className="overflow-visible">
          {/* Y-axis labels */}
          {[0, 1, 2, 3, 4, 5].map((value) => {
            const y = yScale(value) + padding.top;
            return (
              <g key={value}>
                <line
                  x1={padding.left - 5}
                  y1={y}
                  x2={padding.left}
                  y2={y}
                  stroke="#4B5563"
                  strokeWidth="1"
                />
                <text
                  x={padding.left - 10}
                  y={y + 4}
                  textAnchor="end"
                  className="text-xs fill-gray-400"
                >
                  {value === 0 ? "0" : `${value}K`}
                </text>
              </g>
            );
          })}

          {/* Grid lines */}
          {[1, 2, 3, 4, 5].map((value) => {
            const y = yScale(value) + padding.top;
            return (
              <line
                key={value}
                x1={padding.left}
                y1={y}
                x2={padding.left + chartWidth}
                y2={y}
                stroke="#374151"
                strokeWidth="1"
                strokeDasharray="2,2"
                opacity="0.3"
              />
            );
          })}

          {/* Area under running load demand */}
          <path
            d={areaPath}
            fill="url(#gradient)"
            opacity="0.2"
          />
          <defs>
            <linearGradient id="gradient" x1="0%" y1="0%" x2="0%" y2="100%">
              <stop offset="0%" stopColor="#3B82F6" stopOpacity="0.3" />
              <stop offset="100%" stopColor="#3B82F6" stopOpacity="0" />
            </linearGradient>
          </defs>

          {/* Available Capacity line (green, horizontal) */}
          <path
            d={capacityPath}
            stroke="#7FFF00"
            strokeWidth="2"
            fill="none"
            className="drop-shadow-sm"
          />

          {/* Running Load Demand line (blue, fluctuating) */}
          <path
            d={runningLoadPath}
            stroke="#3B82F6"
            strokeWidth="2.5"
            fill="none"
            className="drop-shadow-sm"
          />

          {/* Data points for running load demand */}
          {data.map((point, index) => (
            <circle
              key={index}
              cx={xScale(point.x) + padding.left}
              cy={yScale(point.runningLoadDemand) + padding.top}
              r="3"
              fill="#3B82F6"
              className="drop-shadow-sm"
            />
          ))}

          {/* Tooltip area for available capacity */}
          <g>
            <rect
              x={padding.left + chartWidth - 120}
              y={capacityY - 20}
              width="110"
              height="16"
              fill="#374151"
              rx="2"
              opacity="0.9"
            />
            <text
              x={padding.left + chartWidth - 115}
              y={capacityY - 7}
              className="text-xs fill-white font-medium"
            >
              Available Capacity
            </text>
          </g>
          {/* Green dot at the end of capacity line */}
          <circle
            cx={padding.left + chartWidth - 10}
            cy={capacityY}
            r="4"
            fill="#7FFF00"
            className="drop-shadow-sm"
          />
        </svg>
      </div>

      {/* Dimensions label */}
      <div className="absolute bottom-0 left-1/2 transform -translate-x-1/2 mb-1">
        <div className="bg-blue-500 px-2 py-0.5 rounded text-xs text-white font-mono">
          {width} x {height}
        </div>
      </div>
    </div>
  );
}

